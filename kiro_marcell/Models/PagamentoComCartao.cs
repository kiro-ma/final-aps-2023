using System.ComponentModel.DataAnnotations;

namespace kiro_marcell.Models
{
    public class TipoPagamentoComCartao : TipoDePagamento
    {
        [Display(Name = "Número do cartão")]
        public int NumeroDoCartao { get; set; }

        [Display(Name = "Bandeira")]
        public string? Bandeira { get; set; }
    }
}