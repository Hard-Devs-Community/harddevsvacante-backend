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
		public string Name { get; set; } = String.Empty;
		public string Password { get; set; } = String.Empty;
		public string Username { get; set; } = String.Empty;
		public string Email { get; set; } = String.Empty;

		public int RoleId { get; set; }
		public Rol? Role { get; set; } 
	}
}
