using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Projeto.Domain.DTO;
using Projeto.Domain.Entities;

namespace Projeto.Application.Interfaces
{
    public interface IPedidoApplication : IApplicationBase
    {
        Task<List<Pedido>> ObterPedidos();

        Task<Pedido> ObterPedido(string id);

      //  Task<List<Pedido>> GetListarPedidosFiltro(string status);
        
        string Incluir(PedidoClienteDTO pedidoCliente, string idCliente);

        Task<List<PedidoClienteDTO>> GetListarPedidosCliente(string clienteId);

        Task<List<PedidoClienteDTO>> GetListarPedidosStatus(string statusEntrega);
    }
}
