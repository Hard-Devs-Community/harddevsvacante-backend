using System;
using System.Collections.Generic;
using System.Data;
using System.Net.NetworkInformation;
using System.Reflection.Emit;
using HardDevsVacantes.Core.Base;
using HardDevsVacantes.DataModel.Context.Extensions;
using Microsoft.EntityFrameworkCore;
using HardDevsVacantes.DataModel.Entities;
using HardDevsVacantes.DataModel.Entities.HardDevsVacantes;
using HardDevsVacantes.DataModel.EntityConfiguration.HardDevsVacantes;
using HardDevsVacantes.DataModel.EntityConfiguration;

namespace HardDevsVacantes.DataModel.Context
{

    public interface IMainDbContext : IDisposable
    {
        public DbSet<T> GetDbSet<T>() where T : EntityBase;
        int SaveChanges();
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
    public class MainDbContext : DbContext, IMainDbContext
    {
        public DbSet<T> GetDbSet<T>() where T : EntityBase => Set<T>();

        public DbSet<Autor> Autor { get; set; }
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Libro> Libro { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<VacantesUsuario> Usuarios { get; set; }
        public DbSet<Rol> Roles { get; set; }

        public MainDbContext(DbContextOptions<MainDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioVacantesConfiguration());
            modelBuilder.ApplyConfiguration(new RoleConfiguration());

            base.OnModelCreating(modelBuilder);

        }

    }
    
}

