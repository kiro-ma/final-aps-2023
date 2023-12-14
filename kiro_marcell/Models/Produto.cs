using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace kiro_marcell.Models
{
    public class Produto
    {
        [Display(Name = "Código")]
        public int Id {get;set;}

        [Display(Name = "Nome")]
        public string? Nome {get;set;}

        [Display(Name = "Descrição")]
        public string? Descricao {get;set;}

        [Display(Name = "Preço")]
        public decimal Preco {get;set;}

        [Display(Name = "Quantidade")]
        public int Quantidade {get;set;}

        [Display(Name = "Marca")]
        public Marca? Marca {get;set;}

    }
}