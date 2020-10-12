using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Projeto.Application.Interfaces;
using Projeto.Domain.Entities;
using Projeto.Domain.Interfaces.Services;
using System.Linq;



namespace Projeto.Application.ApplicationServices
{
    public class ClienteApplication : ApplicationBase, IClienteApplication
    {
        private readonly IClienteService _clienteService;

        public ClienteApplication(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        public async Task<List<Cliente>> ObterClientes()
        {
            return await _clienteService.ObterTodosAsync();
        }

        public async Task<List<Cliente>> GetListarClientesFiltro(string ordem, string status = null)
        {
            List<Cliente> cliente = new List<Cliente>();
            
            switch (ordem.ToLower())
            {
                case "id":
                    cliente =  _clienteService.ObterTodos(x => x.Status == status || status == null).OrderBy(x => x.Id).ToList();
                    break;
                case "nome":
                    cliente = _clienteService.ObterTodos(x => x.Status == status || status == null).OrderBy(x => x.Nome).ToList();
                    break;
                case "data_cadastro":
                    cliente = _clienteService.ObterTodos(x => x.Status == status || status == null).OrderBy(x => x.Data_cadastro).ToList();
                    break;
                case "status":
                    cliente = _clienteService.ObterTodos(x => x.Status == status || status == null).OrderBy(x => x.Status).ToList();
                    break;
                default:
                    throw new BusinessException($"Campo informado para ordenação '{ordem}' inválido, informe uma das opções: id, nome, data_cadastro ou status");
            }

            return cliente;
        }

    
        public async Task<Cliente> ObterCliente(string id)
        {
            var clienteResult = _clienteService.ObterPorIdAsync(id);
            
            return await clienteResult;

        }

        public String Incluir(Cliente pedidocliente)

        {
            if (pedidocliente.Nome.ToString().Trim() == "")
                throw new BusinessException("O nome do cliente deve ser informado!");

            pedidocliente.Id = Guid.NewGuid().ToString();

            var clienteResult = _clienteService.ObterPorIdAsync(pedidocliente.Id);
            if (clienteResult.Result != null)
                throw new BusinessException("Cliente já cadastrado");

            pedidocliente.Data_cadastro = DateTime.Today;
            pedidocliente.Status = "Ativo";
            var retorno = _clienteService.Adicionar(pedidocliente);
            
            return retorno.Id;
        }
        public void Atualizar(Cliente cliente)
        {
            var clienteResult = _clienteService.ObterPorIdAsync(cliente.Id);
            if (clienteResult.Result == null)
                throw new BusinessException("Cliente não localizado");

            _clienteService.Atualizar(cliente);

        }
    }
}
