using Projeto.Domain.Entities;
using Projeto.Domain.Interfaces.Repositories;
using Projeto.Domain.Interfaces.Services;
using Projeto.Domain.Interfaces.UnitOfWork;

namespace Projeto.Infra.Data.Services
{
    public class ProdutoService : ServiceBase<Produto>, IProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;
        private readonly IUnitOfWork _unitOfWork;

        public ProdutoService(IUnitOfWork unitOfWork, IProdutoRepository produtoRepository) : base(produtoRepository)
        {
            _produtoRepository = produtoRepository;
            _unitOfWork = unitOfWork;

        }

    }
}