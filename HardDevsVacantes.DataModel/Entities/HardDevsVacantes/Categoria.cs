using System;
using HardDevsVacantes.Core.Base;

namespace HardDevsVacantes.DataModel.Entities
{
    public class Categoria : EntityBase
    {
        public string Nombre { get; set; }

        public ICollection<Libro> Libros { get; set; }
    }
}

