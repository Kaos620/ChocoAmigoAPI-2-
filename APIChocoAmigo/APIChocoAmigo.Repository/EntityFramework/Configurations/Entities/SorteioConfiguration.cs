using APIChocoAmigo.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIChocoAmigo.Repository.EntityFramework.Configurations.Entities
{
    public class SorteioConfiguration : IEntityTypeConfiguration<Sorteio>
    {
        public void Configure(EntityTypeBuilder<Sorteio> builder)
        {
            builder.ToTable("ChocoSorteio");
            builder.HasKey(p => p.SorteioId);

            builder
                .Property(p => p.SorteioId)
                .UseIdentityColumn()
                .HasColumnName("SorteioId")
                .HasColumnType("int");

            builder
                .Property(f => f.UsuarioId)
                .HasColumnName("UsuarioId")
                .HasColumnType("int");

            builder
                .HasOne(f => f.Usuario)
                .WithMany()
                .HasForeignKey(f => f.UsuarioId);

            builder
                .Property(f => f.GrupoId)
                .HasColumnName("GrupoId")
                .HasColumnType("int");

            builder
                .HasOne(f => f.Grupo)
                .WithMany()
                .HasForeignKey(f => f.GrupoId);

            builder
                .Property(f => f.UsuarioSorteado)
                .HasColumnName("UsuarioSorteado")
                .HasColumnType("int");
        }
    }
}
