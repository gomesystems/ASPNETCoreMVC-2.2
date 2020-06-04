using LojaVirtual.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace LojaVirtual.Libraries.Email
{
    public class ContatoEmail
    {
        public static void EnviarContatoPorEmail(Contato contato)
        {   // SMTP envia a msg

            SmtpClient smtp = new SmtpClient("smtp.servicosti.com.br", 587);
            smtp.UseDefaultCredentials = false;       // desabilita as credenciais de segurança deste email
            smtp.Credentials = new NetworkCredential("xxxxxxxxx", "xxxxxxxxxx");
            smtp.EnableSsl = false;


            ///corpo da msg
            string corpoMsg = string.Format("<h2>Contato Loja-Virtual </h2>" +
                "<b> Nome:  </b> {0} <br/>" +
                "<b> E-mail:</b> {1} <br/>" +
                "<b> Texto: </b> {2} <br/>" +
                "<br> E-Mail enviado automaticamente do site Loja Virtual", 
                contato.Nome,
                contato.Email,
                contato.Texto
                );

            // MailMassage -> Construir a menssagem pra enviar

            MailMessage mensagem = new MailMessage();
            mensagem.From = new MailAddress("xxxxxxxxxx");
            mensagem.To.Add("xxxxxxxxxxx");
            mensagem.Subject = "Contato Loja Virtual - E-mail: " + contato.Email;
            mensagem.Body = corpoMsg;
            mensagem.IsBodyHtml = true;

            smtp.Send(mensagem);
        }
    }
}
