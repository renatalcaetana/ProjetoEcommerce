using Projeto.Domain.Entities;
using Projeto.Domain.Interfaces.Repositories;
using Projeto.Infra.Data.Context;

namespace Projeto.Infra.Data.Repositories
{
    public class ProdutoRepository : RepositoryBase<Produto>, IProdutoRepository
    {
        public ProdutoRepository(ProjetoModeloContext projetoModeloContext) : base(projetoModeloContext)
        {

        }
    }
}