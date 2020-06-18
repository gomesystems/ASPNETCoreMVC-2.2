using LojaVirtual.Models;
using LojaVirtual.Reposytories.Contracts;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaVirtual.Controllers
{
    /* A controller  precisa sempre retornar um actionresult ou um iactionresult
     *  produto/listagemCategoria/informatica
     */

    public class ProdutoController : Controller
    {
        private ICategoriaRepository _categoriaRepository;
        private IProdutoRepository _produtoRepository;

        public ProdutoController(ICategoriaRepository categoriaRepository, IProdutoRepository produtoRepository)
        {
            _categoriaRepository = categoriaRepository;
            _produtoRepository = produtoRepository;
        }

        [HttpGet]
        [Route("/Produto/Categoria/{slug}")]
        public IActionResult ListagemCategoria(string slug)
        {
           return View(_categoriaRepository.ObterCategoria(slug));    
        }

        [HttpGet]
        public ActionResult Visualizar(int id)
        {
            return View(_produtoRepository.ObterProduto(id));
        }
    }
}
