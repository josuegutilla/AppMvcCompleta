using GutillaDev.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GutillaDev.Data.Mappings
{
    public class EnderecoMapping : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(p => p.Lagradouro)
                .IsRequired()
                .HasColumnType("varchar(200)");

            builder.Property(p => p.Numero)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(p => p.CEP)
                .IsRequired()
                .HasColumnType("varchar(8)");

            builder.Property(p => p.Complemento)
                .HasColumnType("varchar(250)");

            builder.Property(p => p.Bairro)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(p => p.Cidade)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(p => p.Estado)
                .IsRequired()
                .HasColumnType("varchar(50)");

            builder.ToTable("Enderecos");
        }
    }
}
