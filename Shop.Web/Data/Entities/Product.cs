
namespace Shop.Web.Data.Entities
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)] /*DECORADOS: Modificaciones a los atributos; DATANOTATION*/
        /*CURRENCY 2 (C2) = INDICADOR DE MONEDA, COMO TENGA CONFIGURADA MI PC*/
        public decimal Price { get; set; }

        [Display(Name = "Image")] /*SIRVE PARA QUE EL USUARIO SOLO LO VEA COMO IMAGE*/
        public string ImageUrl { get; set; }

        [Display(Name = "Last Purchase")]
        public DateTime LastPurchase { get; set; }

        [Display(Name = "Last Sale")]
        public DateTime LastSale { get; set; }

        [Display(Name = "Is Availabe?")]
        public bool IsAvailabe { get; set; }

        [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = false)]
        /*NUMERIC 2 = SEPARADORES DE MILES Y DECIMALES*/
        public double Stock { get; set; }

        /**/
    }

}
