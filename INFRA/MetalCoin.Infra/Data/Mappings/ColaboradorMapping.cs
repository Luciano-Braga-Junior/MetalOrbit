using Metalcoin.Core.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MetalCoin.Infra.Data.Mappings
{
    internal class ColaboradorMapping : IEntityTypeConfiguration<Colaborador>
    {
        public void Configure(EntityTypeBuilder<Colaborador> builder)
        {
            builder.ToTable("Colaborador");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Nome)
                .HasColumnType("varchar(100)")
                .IsRequired();

            builder.Property(p => p.Ativo)
                .HasColumnType("bit")
                .IsRequired();

            builder.Property(p => p.Documento)
                .HasColumnType("varchar(100)")
                .IsRequired();

            builder.Property(p => p.DataNascimento)
                .HasColumnType("datetime")
                .IsRequired();

        }
    }
}
