using Projeto.Domain.Entities;
using Projeto.Domain.Interfaces.Repositories;
using Projeto.Infra.Data.Context;

namespace Projeto.Infra.Data.Repositories
{
    public class ClienteRepository : RepositoryBase<Cliente>, IClienteRepository
    {
        public ClienteRepository(ProjetoModeloContext projetoModeloContext) : base(projetoModeloContext)
        {
         
        }
    }
}
