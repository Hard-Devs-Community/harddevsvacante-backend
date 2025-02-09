using System;
using HardDevsVacantes.Core.Base;

namespace HardDevsVacantes.BusinessLayers.Dtos
{
    public class LibroDto : DtoBase
    {
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public DateTime Fecha { get; set; }
        public ICollection<AutorDto> Autores { get; set; }
        public ICollection<CategoriaDto> Categorias { get; set; }

    }
}

