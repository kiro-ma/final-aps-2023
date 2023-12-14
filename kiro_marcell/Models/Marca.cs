using System.ComponentModel.DataAnnotations;

namespace kiro_marcell.Models
{
    public class Marca
    {
        [Display(Name = "Código")]
        public int Id {get;set;}

        [Display(Name = "Nome")]
        public string? Nome {get;set;}

        [Display(Name = "Descrição")]
        public string? Descricao {get;set;}

    }
}