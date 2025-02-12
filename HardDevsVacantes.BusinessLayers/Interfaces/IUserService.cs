using HardDevsVacantes.DataModel.Entities;
using HardDevsVacantes.DataModel.Entities.HardDevsVacantes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardDevsVacantes.BusinessLayers.Interfaces
{
	public interface IUserService
	{
		Task<VacantesUsuario> CreateAsync(Usuario usuario);
		Task<VacantesUsuario?> GetByIdAsync(int Id);
		Task<List<VacantesUsuario>> GetAllAsync();
		Task<Usuario?> UpdateAsync(int Id, Usuario usuario);
		Task<bool> DeleteAsync(int Id);

		Task<Usuario?> LoginAsync(string Username, string Password);
	} 
}
