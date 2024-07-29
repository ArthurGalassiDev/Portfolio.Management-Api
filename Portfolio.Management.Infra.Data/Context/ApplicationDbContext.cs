using Microsoft.EntityFrameworkCore;
using Portfolio.Management.Domain.Entities;

namespace Portfolio.Management.Infra.Data.Context
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
    {
        public DbSet<ProdutoFinanceiro> ProdutosFinanceiros { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Transacao> Transacoes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}