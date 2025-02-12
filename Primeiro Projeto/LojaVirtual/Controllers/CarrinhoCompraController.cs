﻿using AutoMapper;
using LojaVirtual.Libraries.CarrinhoCompra;
using LojaVirtual.Libraries.Gerenciador.Frete;
using LojaVirtual.Libraries.Lang;
using LojaVirtual.Models;
using LojaVirtual.Models.Constants;
using LojaVirtual.Models.ProdutoAgregador;
using LojaVirtual.Reposytories.Contracts;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LojaVirtual.Controllers
{
    public class CarrinhoCompraController : Controller
    {
        private CookieCarrinhoCompra _cookieCarrinhoCompra;
        private IProdutoRepository _produtoRepository;
        private IMapper _mapper;
        private WSCorreiosCalcularFrete _wscorreios;
        private CalcularPacote _calcularPacote;
        private CookieValorPrazoFrete _cookieValorPrazoFrete;

        public CarrinhoCompraController(CookieCarrinhoCompra carrinhoCompra, IProdutoRepository produtoRepository, IMapper mapper, WSCorreiosCalcularFrete wscorreios, CalcularPacote calcularPacote, CookieValorPrazoFrete cookieValorPrazoFrete)
        {
            _cookieCarrinhoCompra = carrinhoCompra;
            _produtoRepository = produtoRepository;
            _mapper = mapper;
            _wscorreios = wscorreios;
            _calcularPacote = calcularPacote;
            _cookieValorPrazoFrete = cookieValorPrazoFrete;
        }
        public IActionResult Index()
        {
            List<ProdutoItem> produtoItemCompleto = CarregarProdutoDB();

            return View(produtoItemCompleto);
        }


        //Item ID = ID Produto
        public IActionResult AdicionarItem(int id)
        {
            Produto produto = _produtoRepository.ObterProduto(id);

            if (produto == null)
            {
                return View("NaoExisteItem");
            }
            else
            {
                var item = new ProdutoItem() { Id = id, QuantidadeProdutoCarrinho = 1 };
                _cookieCarrinhoCompra.Cadastrar(item);

                return RedirectToAction(nameof(Index));
            }
        }
        public IActionResult AlterarQuantidade(int id, int quantidade)
        {
            Produto produto = _produtoRepository.ObterProduto(id);
            if (quantidade < 1)
            {
                return BadRequest(new { mensagem = Mensagen.MSG_E007 });
            }
            else if (quantidade > produto.Quantidade)
            {
                return BadRequest(new { mensagem = Mensagen.MSG_E008 });
            }
            else
            {
                var item = new ProdutoItem() { Id = id, QuantidadeProdutoCarrinho = quantidade };
                _cookieCarrinhoCompra.Atualizar(item);
                return Ok(new { mensagem = Mensagen.MSG_S001 });
            }
        }
        public IActionResult RemoverItem(int id)
        {
            _cookieCarrinhoCompra.Remover(new ProdutoItem() { Id = id });
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> CalcularFrete(int cepDestino)
        {
            try
            {
                List<ProdutoItem> produtos = CarregarProdutoDB();

                List<Pacote> pacotes = _calcularPacote.CalcularPacotesDeProdutos(produtos);

                ValorPrazoFrete valorPAC = await _wscorreios.CalcularFrete(cepDestino.ToString(), TipoFreteConstant.PAC, pacotes);
                ValorPrazoFrete valorSEDEX = await _wscorreios.CalcularFrete(cepDestino.ToString(), TipoFreteConstant.SEDEX, pacotes);
                ValorPrazoFrete valorSEDEX10 = await _wscorreios.CalcularFrete(cepDestino.ToString(), TipoFreteConstant.SEDEX10, pacotes);

                List<ValorPrazoFrete> lista = new List<ValorPrazoFrete>();
                if (valorPAC != null) lista.Add(valorPAC);
                if (valorSEDEX != null) lista.Add(valorSEDEX);
                if (valorSEDEX10 != null) lista.Add(valorSEDEX10);

                _cookieValorPrazoFrete.Cadastrar(lista);

                return Ok(lista);
            }
            catch (Exception e)
            {
                _cookieValorPrazoFrete.Remover();

                return BadRequest(e);
            }
        }






        private List<ProdutoItem> CarregarProdutoDB()
        {
            List<ProdutoItem> produtoItemNoCarrinho = _cookieCarrinhoCompra.Consultar();

            List<ProdutoItem> produtoItemCompleto = new List<ProdutoItem>();

            foreach (var item in produtoItemNoCarrinho)
            {
                Produto produto = _produtoRepository.ObterProduto(item.Id);

                ProdutoItem produtoItem = _mapper.Map<ProdutoItem>(produto);
                produtoItem.QuantidadeProdutoCarrinho = item.QuantidadeProdutoCarrinho;

                produtoItemCompleto.Add(produtoItem);
            }

            return produtoItemCompleto;
        }
    }
}