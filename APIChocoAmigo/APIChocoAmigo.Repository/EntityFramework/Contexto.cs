using APIChocoAmigo.Domain.Entities;
using APIChocoAmigo.Repository.EntityFramework.Configurations.Entities;
using APIChocoAmigo.Repository.EntityFramework.Configurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIChocoAmigo.Repository.EntityFramework
{
    public class Contexto : DbContext
    {
        #region - Atributo e construtor

        private readonly DatabaseSettings _databaseSettings;

        public Contexto(DbContextOptions<Contexto> options, IOptions<DatabaseSettings> databaseSettings)
            : base(options)
        {
            _databaseSettings = databaseSettings.Value;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_databaseSettings.ConnectionString);
        }

        #endregion


        #region - Entities

        public DbSet<Grupo> Grupo { get; set; }
        public DbSet<ParticipanteGrupo> ParticipanteGrupo { get; set; }
        public DbSet<Sorteio> Sorteio { get; set; }
        public DbSet<Usuario> Usuario { get; set; }

        #endregion


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new GrupoConfiguration());
            modelBuilder.ApplyConfiguration(new ParticipanteGrupoConfiguration());
            modelBuilder.ApplyConfiguration(new SorteioConfiguration());
            modelBuilder.ApplyConfiguration(new UsuarioConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
