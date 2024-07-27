using Microsoft.EntityFrameworkCore;
using Portfolio.Management.Domain.Entities;

namespace Portfolio.Management.Infra.Data.Context
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
    {
        public DbSet<Cliente> Clientes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=agdb.c9meiqguuj9w.sa-east-1.rds.amazonaws.com,1433;Database=AGDB;TrustServerCertificate=true;User ID=admin;Password=nCCVgMdiN6y8gaP912o1;");
        }
    }
}