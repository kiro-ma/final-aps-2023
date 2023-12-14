using System.ComponentModel.DataAnnotations;

namespace kiro_marcell.Models
{
    public class Pagamento
    {
        [Display(Name = "Código")]
        public int Id {get;set;}

        [Display(Name = "DataLimite")]
        public DateTime DataLimite {get;set;}

        [Display(Name = "Valor")]
        public decimal Valor {get;set;}

        [Display(Name = "Pago")]
        public Boolean Pago {get;set;}

        [Display(Name = "Notas de venda")]
        public ICollection<NotaDeVenda>? Notas {get;set;}
    }
}