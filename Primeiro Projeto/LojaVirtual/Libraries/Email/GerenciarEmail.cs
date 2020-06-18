using LojaVirtual.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace LojaVirtual.Libraries.Email
{
    public class GerenciarEmail
    {
        private SmtpClient _smpt;
        private IConfiguration _configuration;
        public GerenciarEmail(SmtpClient smpt, IConfiguration configuration)
        {
            _smpt = smpt;
            _configuration = configuration;
        }


        public void EnviarContatoPorEmail(Contato contato)
        {   // SMTP envia a msg p/ contato

            ///corpo da msg
            string corpoMsg = string.Format("<h2>Contato Loja-Virtual </h2>" +
                "<b> Nome:  </b> {0} <br/>" +
                "<b> E-mail:</b> {1} <br/>" +
                "<b> Texto: </b> {2} <br/>" +
                "<br> E-Mail enviado automaticamente do site LojaVirtual",
                contato.Nome,
                contato.Email,
                contato.Texto
                );

            // MailMassage -> Construir a menssagem pra enviar

            MailMessage mensagem = new MailMessage();
            //mensagem.From = new MailAddress("contato@servicosti.com.br");
            mensagem.From = new MailAddress(_configuration.GetValue<string>("Email:Username"));
            mensagem.To.Add("contato@servicosti.com.br");
            mensagem.Subject = "Contato Loja Virtual - E-mail: " + contato.Email;
            mensagem.Body = corpoMsg;
            mensagem.IsBodyHtml = true;

            _smpt.Send(mensagem);

        }

        public void EnviarSenhaParaColaboradorPorEmail(Colaborador colaborador)
        {

            //corpo da msg
            string corpoMsg = string.Format("<h2>Colaborador - LojaVirtual </h2>" +
                "<b> Sua senha é: " +
                "<h3> {0} </h3>", colaborador.Senha);


            // MailMassage -> Construir a menssagem pra enviar
            MailMessage mensagem = new MailMessage();
            mensagem.From = new MailAddress(_configuration.GetValue<string>("Email:Username"));
            mensagem.To.Add(colaborador.Email);
            mensagem.Subject = "Colaborador LojaVirtual - Senha do colaborador: " + colaborador.Nome;
            mensagem.Body = corpoMsg;
            mensagem.IsBodyHtml = true;

            _smpt.Send(mensagem);
        }


    }
}
