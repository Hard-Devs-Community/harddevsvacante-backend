using System;
using HardDevsVacantes.Core.Base;

namespace HardDevsVacantes.DataModel.Entities
{
	public class LibroAutor : EntityBase
	{
		public int? LibroId { get; set; }
        public int? AutorId { get; set; }

		public Libro Libro { get; set; }
		public Autor Autor { get; set; }
    }
}

