using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LojaVirtual.Database;
using LojaVirtual.Libraries.Email;
using LojaVirtual.Models;
using LojaVirtual.Reposytories;
using LojaVirtual.Reposytories.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace LojaVirtual.Controllers
{
    public class HomeController : Controller
    {  

        private IClienteRepository _repositoryCliente;
        private INewsLetterRepository _repositoryNewsLetter;

        public HomeController(IClienteRepository repositoryCliente, INewsLetterRepository repositoryNewsLetter)
        {
            _repositoryCliente = repositoryCliente;
            _repositoryNewsLetter = repositoryNewsLetter;
        }

        [HttpGet]
        public IActionResult Index()
        {            
            return View();
        }
        
        [HttpPost]
        public IActionResult Index([FromForm]NewsLetterEmail newsletter)
        {    
            if(ModelState.IsValid)
            {  //TODO - Adição no banco de dados , indica a tabela que ira gravar conforme o contexto


                _repositoryNewsLetter.cadastrar(newsletter);
                
                TempData["MSG_S"] = "E-mail cadastrado, agora você irá receber promoções especiais no seu e-mail. fique atento as novidades!";
                
                return RedirectToAction(nameof(Index));
                
            }
            else
            {
                return View();
            }          
          
        }


        public IActionResult ContatoAcao()
        {
            /*var contato recebe pela view os parametros do formulario*/

            try
            {
                Contato contato = new Contato();

                contato.Nome = HttpContext.Request.Form["nome"];
                contato.Email = HttpContext.Request.Form["email"];
                contato.Texto = HttpContext.Request.Form["texto"];

                // tratamento de mensagens de erro
                var listaMensagens = new List<ValidationResult>();
                var contexto = new ValidationContext(contato);
                bool isValid = Validator.TryValidateObject(contato, contexto, listaMensagens, true);
                
                if (isValid)
                {
                    ContatoEmail.EnviarContatoPorEmail(contato);

                    // gerencia as mensagens de erro
                    ViewData["MSG_S"] = "Mensagem de contato enviado com sucesso";
                }
                else
                {
                    StringBuilder sb = new StringBuilder();
                    foreach (var texto in listaMensagens)
                    {
                        sb.Append(texto.ErrorMessage);
                    }

                    ViewData["MSG_E"] = sb.ToString();
                    ViewData["CONTATO"] = contato;
                }               
            }


            catch (Exception e)
            {
                ViewData["MSG_E"] = " Ops! tivemos um erro, tente novamente mais tarde" ;
                //TODO - implementar log
            }          

            return View("Contato");
        }

        public IActionResult Contato()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login([FromForm] Cliente cliente)
        {
            if(cliente.Email == "carlos.gomesystems@gmail.com" && cliente.Senha == "Tim@o2020")
            {
                return new ContentResult() { Content = "Logado comsucesso!" };
            }
            else
            {  //não logado
                 return new ContentResult() { Content = "Não Logado!" };
            }

           // return View();
        }


        [HttpGet]
        public IActionResult CadastroCliente()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult CadastroCliente([FromForm]Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                _repositoryCliente.Cadastrar(cliente);             

                TempData["MSG_S"] = "Cadastro realizado com sucesso";

                //TODO - Implementar redirecionamentos diferentes(painel, carrinho , etc)
                return RedirectToAction(nameof(CadastroCliente));

            }            
            return View();
        }

        public IActionResult CarrinhoCompras()
        {
            return View();
        }
    }
}