using LojaVirtual.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaVirtual.Controllers
{    
    /*
        a controller  precisa sempre retornar um actionresult ou um iactionresult
    */
    public class ProdutoController : Controller
    {
        public ActionResult Visualizar()
        {
            Produto produto = GetProduto();

            return View(produto);          
        }

        private Produto GetProduto()
        {
            return new Produto()
            {
                Id = 1,
                Nome = "Plastation 4 ",
                Descricao = "good og war",
                Valor = 300.55M
            };
        }
    }
}
