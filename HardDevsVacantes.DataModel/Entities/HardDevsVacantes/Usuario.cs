using System;
using HardDevsVacantes.Core.Base;
using HardDevsVacantes.DataModel.Enums;

namespace HardDevsVacantes.DataModel.Entities
{
    public class Usuario : EntityBase
    {
        public string Email { get; set; }
        public string Password {get; set;}
        public Rol rol { get; set; }
    }
}

