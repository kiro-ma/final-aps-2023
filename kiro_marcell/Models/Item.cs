using System.ComponentModel.DataAnnotations;

namespace kiro_marcell.Models
{
    public class Item
    {
        [Display(Name = "Código")]
        public int Id {get;set;}

        [Display(Name = "Preço")]
        public decimal Preco {get;set;}

        [Display(Name = "Percentual")]
        public int Percentual {get;set;}

        [Display(Name = "Quantidade")]
        public int Quantidade {get;set;}

        [Display(Name = "Produto")]
        public Produto? Produto {get;set;}

    }
}