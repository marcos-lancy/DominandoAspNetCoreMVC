using FluentValidation;
using FluentValidation.Results;
using Lancy.Dev.Business.Models;
using System.Collections.Generic;
using System.Text;

namespace Lancy.Dev.Business.Services
{
    public abstract class BaseService
    {
        protected void Notificar(ValidationResult validationResult)
        {
            foreach (var error in validationResult.Errors)
            {
                Notificar(error.ErrorMessage);
            }
        }

        protected void Notificar(string mensgem)
        {
            // propagar erro até a controller
        }

        protected bool ExecutarValidacao<TV, TE>(TV validacao, TE entidade) where TV : AbstractValidator<TE> where TE : Entity
        {
            var validator = validacao.Validate(entidade);
            if (validator.IsValid) return true;

            Notificar(validator);

            return false;
        }
    }
}
