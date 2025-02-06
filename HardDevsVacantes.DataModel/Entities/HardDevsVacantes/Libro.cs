using System;
using HardDevsVacantes.Core.Base;

namespace HardDevsVacantes.DataModel.Entities
{
    public class Libro : EntityBase
    {
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public DateTime Fecha { get; set; }
        public ICollection<LibroAutor> Autores { get; set; }
        public ICollection<LibroCategoria> Categorias { get; set; }

    }
}

