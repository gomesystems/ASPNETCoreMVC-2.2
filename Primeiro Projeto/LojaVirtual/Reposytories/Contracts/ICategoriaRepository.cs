using LojaVirtual.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace LojaVirtual.Reposytories.Contracts
{
   public  interface ICategoriaRepository
    {
     
        //CRUD - Categoria
        void Cadastrar(Categoria categoria);
        void Atualizar(Categoria categoria);
        void Excluir(int Id);
        Categoria ObterCategoria(int Id);
        Categoria ObterCategoria(string Slug);

        IEnumerable<Categoria> ObterCategoriasRecursivas( Categoria categoriaPai);
        IEnumerable<Categoria> ObterTodosCategorias();
        IPagedList<Categoria> ObterTodosCategorias(int? pagina);
    }
}
