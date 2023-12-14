using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using kiro_marcell.Models;

namespace kiro_marcell.Models
{
    public class MyDbContext: DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options){}
        public DbSet<Cliente>? Cliente { get; set; }
        public DbSet<Item>? Item { get; set; }
        public DbSet<Marca>? Marca { get; set; }
        public DbSet<NotaDeVenda>? NotaDeVenda { get; set; }
        public DbSet<Pagamento>? Pagamento { get; set; }
        public DbSet<TipoPagamentoComCartao>? TipoPagamentoComCartao { get; set; }
        public DbSet<TipoPagamentoComCheque>? TipoPagamentoComCheque { get; set; }
        public DbSet<Produto>? Produto { get; set; }
        public DbSet<TipoDePagamento>? TipoDePagamento { get; set; }
        public DbSet<Transportadora>? Transportadora { get; set; }
        public DbSet<Vendedor>? Vendedor { get; set; }
    }
}