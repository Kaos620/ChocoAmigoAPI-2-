﻿using APIChocoAmigo.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace APIChocoAmigo.Repository.EntityFramework.Configurations.Entities
{
    public class GrupoConfiguration : IEntityTypeConfiguration<Grupo>
    {
        public void Configure(EntityTypeBuilder<Grupo> builder)
        {
            builder.ToTable("ChocoGrupo");
            builder.HasKey(g => g.GrupoId);

            builder
                .Property(g => g.GrupoId)
                .UseIdentityColumn()
                .HasColumnName("GrupoId")
                .HasColumnType("int");

            builder
                .Property(g => g.NomeGrupo)
                .HasColumnName("NomeGrupo")
                .HasColumnType("varchar(30)");

            builder
                .Property(g => g.QtdMax)
                .HasColumnName("QtdMax")
                .HasColumnType("int");

            builder
                .Property(g => g.Valor)
                .HasColumnName("Valor")
                .HasColumnType("money");

            builder
                .Property(g => g.DataRevelacao)
                .HasColumnName("DataRevelacao")
                .HasColumnType("datetime");

            builder
                .Property(g => g.Descricao)
                .HasColumnName("Descricao")
                .HasColumnType("varchar(300)");

            builder
                .Property(g => g.Icone)
                .HasColumnName("Icone")
                .HasColumnType("varchar(max)");

            builder
                .Property(g => g.SenhaGrupo)
                .HasColumnName("SenhaGrupo")
                .HasColumnType("int");

        }
    }
}
