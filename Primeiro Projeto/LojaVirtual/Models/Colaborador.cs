using LojaVirtual.Libraries.Lang;
using LojaVirtual.Libraries.Validacao;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace LojaVirtual.Models
{
    public class Colaborador
    {
        [Display(Name ="Código")]
        public int Id { get; set; }

        [Required(ErrorMessageResourceType = typeof(Mensagen), ErrorMessageResourceName = "MSG_E001")]
        [MinLength(4, ErrorMessageResourceType = typeof(Mensagen), ErrorMessageResourceName = "MSG_E002")]
        public string Nome { get; set; }


        [Display(Name = "E-Mail")]
        [Required(ErrorMessageResourceType = typeof(Mensagen), ErrorMessageResourceName = "MSG_E001")]
        [EmailAddress(ErrorMessageResourceType = typeof(Mensagen), ErrorMessageResourceName = "MSG_E004")]
        [EmailUnicoColaborador]
        public string Email { get; set; }

        [Required(ErrorMessageResourceType = typeof(Mensagen), ErrorMessageResourceName = "MSG_E001")]
        [MinLength(6, ErrorMessageResourceType = typeof(Mensagen), ErrorMessageResourceName = "MSG_E002")]
        public string Senha { get; set; }

        [NotMapped]
        [Display(Name = "Confirme a senha")]
        [Compare("Senha", ErrorMessageResourceType = typeof(Mensagen), ErrorMessageResourceName = "MSG_E005")]
        public string ConfirmacaoSenha { get; set; }

        /*  colaborador é o adm do sistema
            Tipo:    ColaboradorTipoConstant         
            C-Comum
            G=Gerente 
        */

        public string Tipo { get; set; }
    }
}
