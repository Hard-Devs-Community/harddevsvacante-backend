using System;
using FluentValidation;

namespace HardDevsVacantes.BusinessLayers.Validators.Base
{
    public class AbstractValidatorBase<TModel> : AbstractValidator<TModel> where TModel : class
    {
        public AbstractValidatorBase()
        {
            //validaciones             
        }
    }
}

