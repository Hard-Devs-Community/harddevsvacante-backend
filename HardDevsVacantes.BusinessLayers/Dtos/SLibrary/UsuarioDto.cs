using System;
using HardDevsVacantes.Core.Base;
using HardDevsVacantes.DataModel.Enums;

namespace HardDevsVacantes.BusinessLayers.Dtos
{
    public class UsuarioDto : DtoBase
    {
        public string Email { get; set; }

        public string Password {get; set;}
        public Rol rol { get; set; }
    }
}

