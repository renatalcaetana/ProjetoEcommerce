using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Projeto.Application.Interfaces;
using Projeto.Domain.Entities;
using Projeto.Domain.Interfaces.Services;


namespace Projeto.Application.ApplicationServices
{
    public class ProdutoApplication : ApplicationBase, IProdutoApplication
    {
        private readonly IProdutoService _produtoService;

        public ProdutoApplication(IProdutoService produtoService)
        {
            _produtoService = produtoService;
        }

        public async Task<List<Produto>> ObterProdutos()
        {
            return await _produtoService.ObterTodosAsync();
        }

        public async Task<Produto> ObterProduto(string id)
        {
            return await _produtoService.ObterPorIdAsync(id);
        }

        public string Incluir(Produto produto)
        {
            var retorno = _produtoService.Adicionar(produto);
            return retorno.Id;
        }
    }
}
