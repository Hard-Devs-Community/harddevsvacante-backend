﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Net.NetworkInformation;
using System.Reflection.Emit;
using HardDevsVacantes.Core.Base;
using HardDevsVacantes.DataModel.Context.Extensions;
using Microsoft.EntityFrameworkCore;
using HardDevsVacantes.DataModel.Entities;

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

        public MainDbContext(DbContextOptions<MainDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            foreach (var type in modelBuilder.Model.GetEntityTypes())
            {
                if (typeof(EntityBase).IsAssignableFrom(type.ClrType))
                {
                    modelBuilder.SetSoftDeleteFilter(type.ClrType);
                }
            }

        }

        public void SetAuditEntities()
        {
            foreach (var entry in ChangeTracker.Entries<EntityBase>())
            {
                if (entry.State != EntityState.Deleted)
                {
                    entry.State = EntityState.Modified;
                    entry.Entity.Deleted = true;
                }
            }
        }

        public override int SaveChanges()
        {
            return base.SaveChanges();
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {

            return base.SaveChangesAsync(cancellationToken);
        }


    }
    
}

