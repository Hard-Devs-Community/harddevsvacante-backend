using System;
using HardDevsVacantes.Core.Base;

namespace HardDevsVacantes.DataModel.Entities
{
	public class LibroCategoria : EntityBase
	{
        public int? LibroId { get; set; }
        public int? CategoriaId { get; set; }

        public Libro Libro { get; set; }
        public Categoria Autor { get; set; }
    }
}

