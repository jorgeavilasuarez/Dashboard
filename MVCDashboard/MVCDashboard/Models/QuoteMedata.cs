using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCDashboard.Models
{
    public class QuoteMedata
    {
        [Required(ErrorMessage = "El campo de E-mail es requerido.")]
        [Display(Name = "E-Mail", Prompt = "E-mail")]
        public String ClientEmail { get; set; }

        [Display(Name = "Telefono")]
        public String Phone { get; set; }

        [Display(Name = "Celular")]
        public String CellPhone { get; set; }

        [Display(Name = "Producto")]
        public Nullable<int> ProductId { get; set; }

        [Display(Name = "Cantidad")]
        public Nullable<int> Quantity { get; set; }

        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "El campo de Nombre es requerido.")]
        public String Name { get; set; }

        [Display(Name = "Comentarios")]
        [DataType(DataType.MultilineText)]
        public String Comment { get; set; }
    }

    [MetadataTypeAttribute(typeof(QuoteMedata))]
    public partial class Quote
    {

    }
    public class ProductMedata
    {
        [Display(Name = "Descripción")]
        public string Description { get; set; }
        [Display(Name = "Nombre")]
        public string Name { get; set; }
    }

    [MetadataTypeAttribute(typeof(ProductMedata))]
    public partial class Product
    {        
    }
}