using HardDevsVacantes.DataModel.Entities.HardDevsVacantes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardDevsVacantes.DataModel.EntityConfiguration.HardDevsVacantes
{
	public class RoleConfiguration : IEntityTypeConfiguration<Rol>
	
	{
		public void Configure(EntityTypeBuilder<Rol> builder) 
		{
			builder.ToTable("Usuario");
			builder.HasKey(x => x.Id);

			builder.Property(x => x.Name)
				.HasMaxLength(255)
				.IsRequired();

			
		}

	}
}
