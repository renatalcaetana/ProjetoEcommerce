using Projeto.Domain.Entities;
using Projeto.Domain.Interfaces.Repositories;
using Projeto.Infra.Data.Context;

namespace Projeto.Infra.Data.Repositories
{
    public class ProdutoPedidoRepository : RepositoryBase<ProdutoPedido>, IProdutoPedidoRepository
    {
        public ProdutoPedidoRepository(ProjetoModeloContext projetoModeloContext) : base(projetoModeloContext)
        {

        }
    }
}