using Projeto.Domain.Entities;
using Projeto.Domain.Interfaces.Repositories;
using Projeto.Infra.Data.Context;
using System;

namespace Projeto.Infra.Data.Repositories
{
    public class PedidoRepository : RepositoryBase<Pedido>, IPedidoRepository
    {
        public PedidoRepository(ProjetoModeloContext projetoModeloContext) : base(projetoModeloContext)
        {

        }
    }
}