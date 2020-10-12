using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Projeto.Domain.Entities;

namespace Projeto.Application.Interfaces
{
    public interface IClienteApplication : IApplicationBase
    {
        Task<List<Cliente>> ObterClientes();

        Task<Cliente> ObterCliente(string id);

        string Incluir(Cliente cliente);

        Task<List<Cliente>> GetListarClientesFiltro(string ordem, string status = null);

        void Atualizar(Cliente cliente);



    }
}
