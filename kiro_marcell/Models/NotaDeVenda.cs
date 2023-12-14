using System.ComponentModel.DataAnnotations;

namespace kiro_marcell.Models
{
    public class NotaDeVenda
    {
        [Display(Name = "Código")]
        public int Id {get;set;}

        [Display(Name = "Data")]
        public DateTime Data {get;set;}

        [Display(Name = "Tipo")]
        public Boolean Tipo {get;set;}

        [Display(Name = "Clientes")]
        public ICollection<Cliente>? Clientes {get;set;}

        [Display(Name = "Vendedores")]
        public ICollection<Vendedor>? Vendedors {get;set;}

        [Display(Name = "Transportadoras")]
        public ICollection<Transportadora>? Transportadoras {get;set;}

        [Display(Name = "Item")]
        public Item? Item {get;set;}
    }
}