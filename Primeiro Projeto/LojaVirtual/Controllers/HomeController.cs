using System;
using System.Collections.Generic;
using LojaVirtual.Libraries.Email;
using LojaVirtual.Models;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Microsoft.AspNetCore.Http;
using LojaVirtual.Libraries.Login;
using LojaVirtual.Reposytories.Contracts;

namespace LojaVirtual.Controllers
{
    public class HomeController : Controller
    {
        private INewsLetterRepository _repositoryNewsletter;        
        private GerenciarEmail _gerenciarEmail;
        private IProdutoRepository _produtoRepository;

        public HomeController(IProdutoRepository produtoRepository, IClienteRepository repositoryCliente, INewsLetterRepository repositoryNewsletter, LoginCliente loginCliente, GerenciarEmail gerenciarEmail)
        {            
            _repositoryNewsletter = repositoryNewsletter;            
            _gerenciarEmail = gerenciarEmail;
            _produtoRepository = produtoRepository;
        }

        [HttpGet]
        public IActionResult Index()
        {            
            return View();
        }

        [HttpPost]
        public IActionResult Index([FromForm]NewsLetterEmail newsletter)
        {
            if (ModelState.IsValid)
            {
                _repositoryNewsletter.cadastrar(newsletter);
                
                TempData["MSG_S"] = "E-mail cadastrado! Agora você vai receber promoções especiais no seu e-mail! Fique atento as novidades!";
                
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View();
            }
        }
        public IActionResult Categoria()
        {
            return View();
        }

        public IActionResult Contato()
        {
            return View();
        }
        public IActionResult ContatoAcao()
        {
            try
            {
                Contato contato = new Contato();
                contato.Nome = HttpContext.Request.Form["nome"];
                contato.Email = HttpContext.Request.Form["email"];
                contato.Texto = HttpContext.Request.Form["texto"];
                
                var listaMensagens = new List<ValidationResult>();
                var contexto = new ValidationContext(contato);
                bool isValid = Validator.TryValidateObject(contato, contexto, listaMensagens, true);

                if (isValid)
                {
                    _gerenciarEmail.EnviarContatoPorEmail(contato);

                    ViewData["MSG_S"] = "Mensagem de contato enviado com sucesso!";
                }
                else
                {
                    StringBuilder sb = new StringBuilder();
                    foreach (var texto in listaMensagens)
                    {
                        sb.Append(texto.ErrorMessage + "<br />");
                    }

                    ViewData["MSG_E"] = sb.ToString();
                    ViewData["CONTATO"] = contato;
                }

                
            }
            catch (Exception e)
            {
                ViewData["MSG_E"] = "Opps! Tivemos um erro, tente novamente mais tarde!";

                //TODO - Implementar Log
            }
            

            return View("Contato");
        }


    }
}