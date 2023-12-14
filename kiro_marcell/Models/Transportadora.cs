using System.ComponentModel.DataAnnotations;

namespace kiro_marcell.Models
{
    public class Transportadora
    {
        [Display(Name = "Código")]
        public int Id {get;set;}

        [Display(Name = "Nome")]
        public string? Nome {get;set;}

    }
}