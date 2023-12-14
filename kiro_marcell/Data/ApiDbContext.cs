#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using kiro_marcell.Models;

    public class ApiDbContext : DbContext
    {
        public ApiDbContext (DbContextOptions<ApiDbContext> options)
            : base(options)
        {
        }
        public DbSet<kiro_marcell.Models.Produto> Produto { get; set; }
        public DbSet<kiro_marcell.Models.Cliente> Cliente { get; set; }
        public DbSet<kiro_marcell.Models.Item> Item { get; set; }
        public DbSet<kiro_marcell.Models.Marca> Marca { get; set; }
        public DbSet<kiro_marcell.Models.NotaDeVenda> NotaDeVenda { get; set; }
        public DbSet<kiro_marcell.Models.Pagamento> Pagamento { get; set; }
        public DbSet<kiro_marcell.Models.TipoDePagamento> TipoDePagamento { get; set; }
        public DbSet<kiro_marcell.Models.Transportadora> Transportadora { get; set; }
        public DbSet<kiro_marcell.Models.Vendedor> Vendedor { get; set; }
    }
