using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using HardDevsVacantes.DataModel.Entities;

namespace HardDevsVacantes.DataModel.EntityConfiguration
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("Usuario");
            builder.HasKey(x => x.Id).HasName("UsuarioId");
            builder.Property(x => x.Email).IsRequired().HasMaxLength(40);
        }
    }
}

