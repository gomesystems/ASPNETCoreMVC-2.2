using LojaVirtual.Database;
using LojaVirtual.Migrations;
using LojaVirtual.Models;
using LojaVirtual.Reposytories.Contracts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace LojaVirtual.Reposytories
{
    public class CategoriaRepository : ICategoriaRepository
    {

        private IConfiguration _config;
        LojaVirtualContext _banco;
        public  CategoriaRepository(LojaVirtualContext banco, IConfiguration configuration)
        {
            _banco = banco;
            _config = configuration;
        }


    public void Cadastrar(Categoria categoria)
        {
            _banco.Add(categoria);
            _banco.SaveChanges();
        }

        public void Atualizar(Categoria categoria)
        {
            _banco.Update(categoria);
            _banco.SaveChanges();
        }

        public void Excluir(int Id)
        {
            Categoria categoria = ObterCategoria(Id);
            _banco.Remove(categoria);
            _banco.SaveChanges();
        }

        public Categoria ObterCategoria(int Id)
        {
            return _banco.Categorias.Find(Id);
        }

        public IPagedList<Categoria> ObterTodosCategorias(int? pagina)
        {
            int RegistroPorPagina = _config.GetValue<int>("RegistroPorPagina");

            int NumeroPagina = pagina ?? 1;            
            return _banco.Categorias.Include(a => a.CategoriaPai).ToPagedList<Categoria>(NumeroPagina, RegistroPorPagina); 
        }

        public IEnumerable<Categoria> ObterTodosCategorias()
        {
            return _banco.Categorias;
        }
    }
}
     
