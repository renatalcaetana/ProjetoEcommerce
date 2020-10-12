using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Projeto.Domain.Entities;

namespace Projeto.Application.Interfaces
{
    public interface IProdutoApplication : IApplicationBase
    {
        Task<List<Produto>> ObterProdutos();

        Task<Produto> ObterProduto(string id);

        string Incluir(Produto produto);
    }
}
