using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaVirtual.Libraries.Filtro
{

    // Se a requisição vir de outro site, não aceita.
    public class ValidateHttpRefererAttribute : Attribute, IActionFilter
    {
        // TODO -  Executado após passar pelo controlador
        public void OnActionExecuted(ActionExecutedContext context)
        {
            string referer = context.HttpContext.Request.Headers["Referer"].ToString();

            if (string.IsNullOrEmpty(referer))
            {
                context.Result = new ContentResult() { Content = "Acesso Negado!!!" };
            }
            else
            {
                Uri uri = new Uri(referer);

                string hostReferer = uri.Host;
                string hostServidor = context.HttpContext.Request.Host.Host;

                if (hostReferer != hostServidor)
                {
                    context.Result = new ContentResult() { Content = "Acesso Negado!!!" };
                }

            }

        }

        // TODO -  Executado antes passar pelo controlador
        public void OnActionExecuting(ActionExecutingContext context)
        {
            //Executado após passar pelo controlador
        }
    }
}
