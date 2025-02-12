﻿using LojaVirtual.Libraries.Lang;
using Microsoft.AspNetCore.Mvc.Razor.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LojaVirtual.Models
{
    public class Cliente
    {
        public int ID { get; set; }

        [Required(ErrorMessageResourceType = typeof(Mensagen), ErrorMessageResourceName = "MSG_E001")]
        [MinLength(4, ErrorMessageResourceType = typeof(Mensagen), ErrorMessageResourceName = "MSG_E002")]
        public string Nome { get; set; }

        [Required(ErrorMessageResourceType = typeof(Mensagen), ErrorMessageResourceName = "MSG_E001")]
        public DateTime Nascimento { get; set; }

        [Required(ErrorMessageResourceType = typeof(Mensagen), ErrorMessageResourceName = "MSG_E001")]
        public string Sexo { get; set; }

        [Required(ErrorMessageResourceType = typeof(Mensagen), ErrorMessageResourceName = "MSG_E001")]
        public string Cpf { get; set; }

        [Required(ErrorMessageResourceType = typeof(Mensagen), ErrorMessageResourceName = "MSG_E001")]
        public string Telefone { get; set; }

        [Required(ErrorMessageResourceType = typeof(Mensagen), ErrorMessageResourceName = "MSG_E001")]
        [EmailAddress(ErrorMessageResourceType = typeof(Mensagen), ErrorMessageResourceName = "MSG_E004")]
        public string Email { get; set; }

        [Required(ErrorMessageResourceType = typeof(Mensagen), ErrorMessageResourceName = "MSG_E001")]
        [MinLength(10, ErrorMessageResourceType = typeof(Mensagen), ErrorMessageResourceName = "MSG_E002")]
        [MaxLength(10, ErrorMessageResourceType = typeof(Mensagen), ErrorMessageResourceName = "MSG_E003")]
        public string CEP { get; set; }

        [Required(ErrorMessageResourceType = typeof(Mensagen), ErrorMessageResourceName = "MSG_E001")]
        public string Estado { get; set; }

        [Required(ErrorMessageResourceType = typeof(Mensagen), ErrorMessageResourceName = "MSG_E001")]
        public string Cidade { get; set; }

        [Display(Name = "Endereço")]
        [Required(ErrorMessageResourceType = typeof(Mensagen), ErrorMessageResourceName = "MSG_E001")]
        public string Endereco { get; set; }

        [Required(ErrorMessageResourceType = typeof(Mensagen), ErrorMessageResourceName = "MSG_E001")]
        public string Complemento { get; set; }

        [Display(Name = "Número")]
        public string Numero { get; set; }



        [Required(ErrorMessageResourceType = typeof(Mensagen), ErrorMessageResourceName = "MSG_E001")]
        [MinLength(6, ErrorMessageResourceType = typeof(Mensagen), ErrorMessageResourceName = "MSG_E002")]
        public string Senha { get; set; }

        [NotMapped]
        [Display(Name = "Confirme a senha")]
        [Compare("Senha", ErrorMessageResourceType = typeof(Mensagen), ErrorMessageResourceName = "MSG_E005")]
        public string ConfirmacaoSenha { get; set; }

        [Display(Name = "Situação")]
        public string Situacao { get; set; }

    }
}
