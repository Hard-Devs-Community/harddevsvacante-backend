using System;
using HardDevsVacantes.Core.Base;

namespace HardDevsVacantes.BusinessLayers.Dtos
{
	public class AutorDto : DtoBase
	{
		public string Nombre { get; set; }

        public ICollection<LibroDto> Libros { get; set; }
    }
}

