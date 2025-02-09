using System;
using HardDevsVacantes.Core.Base;

namespace HardDevsVacantes.BusinessLayers.Dtos
{
	public class AuthDto : DtoBase
	{
        public string Email { get; set; }

        public string Password { get; set; }
    }
}

