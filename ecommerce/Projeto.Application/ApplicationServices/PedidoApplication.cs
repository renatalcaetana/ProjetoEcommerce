using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Projeto.Application.Interfaces;
using Projeto.Domain.Entities;
using Projeto.Domain.Interfaces.Services;
using Projeto.Domain.DTO;


namespace Projeto.Application.ApplicationServices
{
    public class PedidoApplication : ApplicationBase, IPedidoApplication
    {
        private readonly IPedidoService _pedidoService;
        private readonly IProdutoPedidoService _produtoPedidoService;
        private readonly IClienteService _clienteService;
        private readonly IProdutoService _produtoService;


        public PedidoApplication(IPedidoService pedidoService, IProdutoPedidoService produtoPedidoService, IClienteService clienteService, IProdutoService produtoService)
        {
            _pedidoService = pedidoService;
            _produtoPedidoService = produtoPedidoService;
            _clienteService = clienteService;
            _produtoService = produtoService;

        }

        public async Task<List<Pedido>> ObterPedidos()
        {
            return await _pedidoService.ObterTodosAsync();
        }

        public async Task<Pedido> ObterPedido(string id)
        {
            return await _pedidoService.ObterPorIdAsync(id);
        }

    
        public async Task<List<PedidoClienteDTO>> GetListarPedidosCliente(string clienteId)
        {

            List<PedidoClienteDTO> listpedidocliente = new List<PedidoClienteDTO>();
    
            var pedidos = await _pedidoService.ObterTodosAsync(x => x.ClienteId == clienteId);

            return ListarPedidos(pedidos);
                  
        }


        public async Task<List<PedidoClienteDTO>> GetListarPedidosStatus(string statusEntrega)
        {

            List<PedidoClienteDTO> listpedidocliente = new List<PedidoClienteDTO>();
        
            var pedidos = await _pedidoService.ObterTodosAsync(x => x.Status_entrega == statusEntrega);

            return ListarPedidos(pedidos);

        }

        private List<PedidoClienteDTO> ListarPedidos(List<Pedido> pedidos)
        {

            List<PedidoClienteDTO> listpedidocliente = new List<PedidoClienteDTO>();

         
            foreach (var item in pedidos)
            {
                var produtos = _produtoPedidoService.ObterTodos(x => x.PedidoId == item.Id);
                List<Produto> listProduto = new List<Produto>();

                foreach (var produto in produtos)
                {
                    listProduto.Add(new Produto { Id = produto.ProdutoId, Nome = produto.Produto.Nome, Disponivel = produto.Produto.Disponivel, Valor = produto.Produto.Valor });

                }

                listpedidocliente.Add(new PedidoClienteDTO
                {
                    ClienteId = item.ClienteId,
                    Data_cadastro = item.Data_cadastro,
                    Id = item.Id,
                    Status_entrega = item.Status_entrega,
                    Produto = listProduto,
                    Quantidade = produtos.Count

                }
                );
            }
            return listpedidocliente;


        }

        public string Incluir(PedidoClienteDTO pedidoCliente,string idCliente)
        {

            List<ProdutoPedido> listProdutoPedido = new List<ProdutoPedido>();

           
            var clienteResult = _clienteService.ObterPorIdAsync(idCliente);
            if (clienteResult.Result == null)
                throw new BusinessException("Cliente não localizado");

            var idPedido = Guid.NewGuid().ToString();
            var pedido = (new Pedido { ClienteId = idCliente, Data_cadastro = DateTime.Today, Id = idPedido, Status_entrega = "Pendente" });

            if (listProdutoPedido.Count > 0)
                throw new BusinessException("Nenhum produto foi informado");

            foreach (var produto in pedidoCliente.Produto)
            {
                var produtoResult = _produtoService.ObterPorIdAsync(produto.Id);
                if (produtoResult.Result == null)
                    throw new BusinessException("Produto não localizado");

                listProdutoPedido.Add(new ProdutoPedido { PedidoId = idPedido, ProdutoId = produto.Id});

            }
            var retorno = _pedidoService.Adicionar(pedido);
            _produtoPedidoService.AdicionarLista(listProdutoPedido);

            return pedidoCliente.ClienteId;

        }




    }
}
