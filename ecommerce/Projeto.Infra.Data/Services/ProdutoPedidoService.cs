using Projeto.Domain.Entities;
using Projeto.Domain.Interfaces.Repositories;
using Projeto.Domain.Interfaces.Services;
using Projeto.Domain.Interfaces.UnitOfWork;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Projeto.Infra.Data.Services
{
    public class ProdutoPedidoService : ServiceBase<ProdutoPedido>, IProdutoPedidoService
    {
        private readonly IProdutoPedidoRepository _produtoPedidoRepository;
        private readonly IUnitOfWork _unitOfWork;

        public ProdutoPedidoService(IUnitOfWork unitOfWork, IProdutoPedidoRepository produtoPedidoRepository) : base(produtoPedidoRepository)
        {
            _produtoPedidoRepository = produtoPedidoRepository;
            _unitOfWork = unitOfWork;

        }


    }
}