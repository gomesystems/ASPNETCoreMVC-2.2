﻿using LojaVirtual.Libraries.Arquivo;
using LojaVirtual.Libraries.Filtro;
using LojaVirtual.Libraries.Lang;
using LojaVirtual.Models;
using LojaVirtual.Models.ProdutoAgregador;
using LojaVirtual.Reposytories.Contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace LojaVirtual.Areas.Colaborador.Controllers
{
    [Area("Colaborador")]
   [ColaboradorAutorizacao]
    public class ProdutoController : Controller
    {
        private IProdutoRepository _produtoRepository;
        private ICategoriaRepository _categoriaRepository;
        private IImagemRepository _imagemRepository;

        public ProdutoController(IProdutoRepository produtoRepository, ICategoriaRepository categoriaRepository, IImagemRepository imagemRepository)
        {
            _produtoRepository = produtoRepository;
            _categoriaRepository = categoriaRepository;
            _imagemRepository = imagemRepository;
        }

        public IActionResult Index(int? pagina, string pesquisa)
        {
            var produtos = _produtoRepository.ObterTodosProdutos(pagina, pesquisa);
            return View(produtos);
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            ViewBag.Categorias = _categoriaRepository.ObterTodosCategorias().Select(a => new SelectListItem(a.Nome, a.Id.ToString()));
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Produto produto)
        {
            if (ModelState.IsValid)
            {
                //TODO - Mover  o caminho definitivo no banco , esta vem do caminho temporário. 

                _produtoRepository.Cadastrar(produto);

                List<Imagem> ListaImagensDef = GerenciadorArquivo.MoverImagensProduto(new List<string>(Request.Form["imagem"]), produto.Id);
                _imagemRepository.CadastrarImagens(ListaImagensDef, produto.Id);

                TempData["MSG_S"] = Mensagen.MSG_S001;
                return RedirectToAction(nameof(Index));
            }
            else
            {
                ViewBag.Categorias = _categoriaRepository.ObterTodosCategorias().Select(a => new SelectListItem(a.Nome, a.Id.ToString()));
                produto.Imagens = new List<string>(Request.Form["imagem"]).Where(a => a.Trim().Length > 0).Select(a => new Imagem() { Caminho = a }).ToList();
                return View(produto);
            }
        }

        [HttpGet]
        public IActionResult Atualizar(int id)
        {
            ViewBag.Categorias = _categoriaRepository.ObterTodosCategorias().Select(a => new SelectListItem(a.Nome, a.Id.ToString()));
            Produto produto = _produtoRepository.ObterProduto(id);

            return View(produto);
        }

        [HttpPost]
        public IActionResult Atualizar(Produto produto, int id)
        {
            if (ModelState.IsValid)
            {
                //TODO - Mover  o caminho definitivo no banco , esta vem do caminho temporário. 

                _produtoRepository.Atualizar(produto);

                //TODO - Não mover imagens na pasta definitiva.
                List<Imagem> ListaImagensDef = GerenciadorArquivo.MoverImagensProduto(new List<string>(Request.Form["imagem"]), produto.Id);

                _imagemRepository.ExcluirImagensDoProduto(produto.Id);
                _imagemRepository.CadastrarImagens(ListaImagensDef, produto.Id);

                TempData["MSG_S"] = Mensagen.MSG_S001;
                return RedirectToAction(nameof(Index));
            }
            else
            {
                ViewBag.Categorias = _categoriaRepository.ObterTodosCategorias().Select(a => new SelectListItem(a.Nome, a.Id.ToString()));
                produto.Imagens = new List<string>(Request.Form["imagem"]).Where(a => a.Trim().Length > 0).Select(a => new Imagem() { Caminho = a }).ToList();
                return View(produto);
            }
        }
        [HttpGet]
        [ValidateHttpReferer]
        public IActionResult Excluir(int id)
        {
            // TODO - Ler produto, deletar produto com todas as imagens
            Produto produto = _produtoRepository.ObterProduto(id);
            GerenciadorArquivo.ExcluirImagensProduto(produto.Imagens.ToList());
            _imagemRepository.ExcluirImagensDoProduto(id);
            _produtoRepository.Excluir(id);

            TempData["MSG_S"] = Mensagen.MSG_S002;

            return RedirectToAction(nameof(Index));
        }
    }
}