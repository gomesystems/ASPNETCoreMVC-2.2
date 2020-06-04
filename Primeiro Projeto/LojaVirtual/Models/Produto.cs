using LojaVirtual.Libraries.Lang;
using Microsoft.AspNetCore.Mvc.Razor.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LojaVirtual.Models
{
    public class Produto
    {
        public int Id { get; set; }


        [Required(ErrorMessageResourceType = typeof(Mensagen), ErrorMessageResourceName = "MSG_E001")]
        public string Nome { get; set; }

        [Required(ErrorMessageResourceType = typeof(Mensagen), ErrorMessageResourceName = "MSG_E001")]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        [Required(ErrorMessageResourceType = typeof(Mensagen), ErrorMessageResourceName = "MSG_E001")]
        [Display(Name = "Preço")]
        public decimal Valor { get; set; }

        [Required(ErrorMessageResourceType = typeof(Mensagen), ErrorMessageResourceName = "MSG_E001")]
        [Range(0, 100000, ErrorMessageResourceType = typeof(Mensagen), ErrorMessageResourceName = "MSG_E006")]
        public int Quantidade { get; set; }

        //Frete - correios
        [Range(0.001, 30, ErrorMessageResourceType = typeof(Mensagen), ErrorMessageResourceName = "MSG_E006")]
        [Required(ErrorMessageResourceType = typeof(Mensagen), ErrorMessageResourceName = "MSG_E001")]
        public double Peso { get; set; }

        [Range(11,105, ErrorMessageResourceType = typeof(Mensagen), ErrorMessageResourceName = "MSG_E006")]
        [Required(ErrorMessageResourceType = typeof(Mensagen), ErrorMessageResourceName = "MSG_E001")]
        public int Largura { get; set; }

        [Range(2, 105, ErrorMessageResourceType = typeof(Mensagen), ErrorMessageResourceName = "MSG_E006")]
        [Required(ErrorMessageResourceType = typeof(Mensagen), ErrorMessageResourceName = "MSG_E001")]
        public int Altura { get; set; }

        [Range(16, 105, ErrorMessageResourceType = typeof(Mensagen), ErrorMessageResourceName = "MSG_E006")]
        [Required(ErrorMessageResourceType = typeof(Mensagen), ErrorMessageResourceName = "MSG_E001")]
        public int Comprimento { get; set; }


        // relacionamento entre objetos e banco (ORM)      
        // Esse relacionamento pode ser feito por :
        // Fluente API/ Attributes, como segue abaixo:
        

        [Required(ErrorMessageResourceType = typeof(Mensagen), ErrorMessageResourceName = "MSG_E001")]
        [Display(Name = "Categoria")]
        public int CategoriaId { get; set; }

        //POO - associação entre objetos
        [ForeignKey("CategoriaId")]
        public virtual Categoria Categoria { get; set; }

        public virtual ICollection<Imagem> Imagens { get; set; }

    }
}
