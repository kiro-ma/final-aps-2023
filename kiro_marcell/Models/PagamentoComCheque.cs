using System.ComponentModel.DataAnnotations;

namespace kiro_marcell.Models
{
    public class TipoPagamentoComCheque : TipoDePagamento
    {
        [Display(Name = "Banco")]
        public int Banco { get; set; }

        [Display(Name = "Nome do banco")]
        public string? NomeDoBanco { get; set; }
    }
}