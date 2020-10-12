using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Projeto.Application.Interfaces;
using Projeto.Domain.Entities;
using Projeto.Domain.Interfaces.Services;


namespace Projeto.Application.ApplicationServices
{
    public class ProdutoPedidoApplication : ApplicationBase, IProdutoPedidoApplication
    {
        private readonly IProdutoPedidoService _produtoPedidoService;

        public ProdutoPedidoApplication(IProdutoPedidoService produtoPedidoService)
        {
            _produtoPedidoService = produtoPedidoService;
        }

        public async Task<List<ProdutoPedido>> ObterProdutoPedidos()
        {
            return await _produtoPedidoService.ObterTodosAsync();
        }

        public async Task<ProdutoPedido> ObterProdutoPedido(string id)
        {
            return await _produtoPedidoService.ObterPorIdAsync(id);
        }

        public string Incluir(ProdutoPedido produtoPedido)
        {
            var retorno = _produtoPedidoService.Adicionar(produtoPedido);
            return retorno.PedidoId;
        }
      


    }
}

