﻿using LojaVirtual.Models;
using LojaVirtual.Models.ProdutoAgregador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace LojaVirtual.Reposytories.Contracts
{
   public interface IProdutoRepository
    {
        void Cadastrar(Produto produto);
        void Atualizar(Produto produto);
        void Excluir(int Id);

        Produto ObterProduto(int Id);        
        IPagedList<Produto> ObterTodosProdutos(int? pagina, string pesquisa);
        IPagedList<Produto> ObterTodosProdutos(int? pagina, string pesquisa, string ordenacao, IEnumerable<Categoria> categorias);
    }
}
