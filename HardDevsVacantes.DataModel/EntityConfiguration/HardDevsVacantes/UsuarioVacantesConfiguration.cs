using HardDevsVacantes.DataModel.Entities;
using HardDevsVacantes.DataModel.Entities.HardDevsVacantes;
using HardDevsVacantes.DataModel.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardDevsVacantes.DataModel.EntityConfiguration.HardDevsVacantes
{
	public class UsuarioVacantesConfiguration : IEntityTypeConfiguration<VacantesUsuario>
	{
		public void Configure(EntityTypeBuilder<VacantesUsuario> builder)
		{
			builder.ToTable("Usuario");

			builder.HasKey(x => x.Id);

			builder.Property(x => x.Name)
				.HasMaxLength(225)
				.IsRequired();

			builder.Property(x => x.Password)
				.HasMaxLength(225)
				.IsRequired();

			builder.Property(x => x.Username)
				.HasMaxLength(225)
				.IsRequired();

			builder.HasOne(x => x.Role)
				.WithMany()
				.HasForeignKey(x => x.RoleId);
		}
	}
}
