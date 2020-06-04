using LojaVirtual.Libraries.Lang;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LojaVirtual.Models
{
    public class Categoria
    {
        [Display(Name = "Código")]
        public int Id { get; set; }
       
        [Required(ErrorMessageResourceType = typeof(Mensagen), ErrorMessageResourceName = "MSG_E001")]
        [MinLength(4, ErrorMessageResourceType = typeof(Mensagen), ErrorMessageResourceName = "MSG_E002")]
        //TODO - Criar validação nome categoria unico no banco de dados.
        public string Nome { get; set; }

        /*Slug Url amigável*/
        [Required(ErrorMessageResourceType = typeof(Mensagen), ErrorMessageResourceName = "MSG_E001")]
        [MinLength(4, ErrorMessageResourceType = typeof(Mensagen), ErrorMessageResourceName = "MSG_E002")]
        public string Slug { get; set; }

        /* Auto-relacionamento
          1- Informática
           2 -Mouse
           3 --mouse Sem Fio
           4 --Mouse gamer
        */
     
        [Display(Name = "Categoria Pai")]
        public int? CategoriaPaiId { get; set; }

        [ForeignKey("CategoriaPaiId")]
        public virtual Categoria CategoriaPai { get; set; }
    }
}
