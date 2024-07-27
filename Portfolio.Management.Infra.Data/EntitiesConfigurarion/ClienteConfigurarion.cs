using Microsoft.EntityFrameworkCore;
using Portfolio.Management.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Portfolio.Management.Infra.Data.EntitiesConfigurarion
{
    internal class ClienteConfigurarion : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> entity)
        {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Nome).IsRequired().HasMaxLength(100);
                entity.Property(e => e.Email).IsRequired().HasMaxLength(100);
                entity.HasIndex(e => e.Email).IsUnique();
        }
    }
}
