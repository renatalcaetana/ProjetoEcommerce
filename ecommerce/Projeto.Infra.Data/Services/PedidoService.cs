using Projeto.Domain.Entities;
using Projeto.Domain.Interfaces.Repositories;
using Projeto.Domain.Interfaces.Services;
using Projeto.Domain.Interfaces.UnitOfWork;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Projeto.Infra.Data.Services
{
    public class PedidoService : ServiceBase<Pedido>, IPedidoService
    {
        private readonly IPedidoRepository _pedidoRepository;
        private readonly IUnitOfWork _unitOfWork;

        public PedidoService(IUnitOfWork unitOfWork, IPedidoRepository pedidoRepository) : base(pedidoRepository)
        {
            _pedidoRepository = pedidoRepository;
            _unitOfWork = unitOfWork;

        }
      
    }
}