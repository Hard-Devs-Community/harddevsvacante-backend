using System;
using HardDevsVacantes.Core.Base;
using HardDevsVacantes.DataModel.Entities;

namespace HardDevsVacantes.BusinessLayers.Dtos
{
	public class LibroAutorDto : DtoBase
	{
        public int? LibroId { get; set; }
        public int? CategoriaId { get; set; }

        public LibroDto Libro { get; set; }
        public CategoriaDto Autor { get; set; }
    }
}

