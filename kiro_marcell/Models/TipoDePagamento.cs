using System.ComponentModel.DataAnnotations;

namespace kiro_marcell.Models
{
    public class TipoDePagamento
    {
        [Display(Name = "Código")]
        public int Id {get;set;}

        [Display(Name = "Nome do cobrado")]
        public string? NomeDoCobrado {get;set;}

        [Display(Name = "Informacoes adicionais")]
        public decimal InformacoesAdicionais {get;set;}

    }
}