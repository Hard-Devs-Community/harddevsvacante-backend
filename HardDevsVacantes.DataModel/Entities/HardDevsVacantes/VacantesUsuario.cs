using HardDevsVacantes.DataModel.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardDevsVacantes.DataModel.Entities.HardDevsVacantes
{
	public class VacantesUsuario
	{
		public int Id { get; set; }
		public string Nombre { get; set; } = default!;
		public string Contrasena { get; set; } = default!;
		public string Username { get; set; } = default!;
		public string Email { get; set; } = default!;

		public int RolId { get; set; }
		public Rol? Rol { get; set; } 
	}
}
