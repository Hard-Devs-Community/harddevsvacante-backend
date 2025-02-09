using System;
using FluentValidation;
using HardDevsVacantes.DataModel.Entities;

namespace HardDevsVacantes.BusinessLayers.Validators.SLibrary
{
	public class UsuarioValidator : AbstractValidator<Usuario>
    {
        public UsuarioValidator() { }
    }
}

