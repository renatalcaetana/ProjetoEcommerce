using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Projeto.Domain.Entities;

namespace Projeto.Application.Interfaces
{
    public interface IProdutoPedidoApplication : IApplicationBase
    {
        Task<List<ProdutoPedido>> ObterProdutoPedidos();

        Task<ProdutoPedido> ObterProdutoPedido(string id);

       // Task<List<ProdutoPedido>> GetListarProdutoPedidoFiltro(string clienteId);
        
        string Incluir(ProdutoPedido produtoPedido);
    }
}
