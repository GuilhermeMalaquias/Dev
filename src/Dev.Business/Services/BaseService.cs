using Dev.Business.Interfaces;
using Dev.Business.Models;
using Dev.Business.Notificacoes;
using FluentValidation;
using FluentValidation.Results;

namespace Dev.Business.Services
{
    public abstract class BaseService
    {
        private readonly INotificador _notificador;

        protected BaseService(INotificador notificador)
        {
            _notificador = notificador;
        }
        protected void Notificar(ValidationResult validationResult)
        {
            validationResult.Errors.ForEach(v => Notificar(v.ErrorMessage));
        }
        protected void Notificar(string errorMessage)
        {
            _notificador.Handle(new Notificacao(errorMessage));
        }

        protected bool ExecutarValidacao<TV, TE>(TV validation, 
                                                 TE entidade) where TV: AbstractValidator<TE> where TE: Entity
        {
            var result = validation.Validate(entidade);
            if (result.IsValid) return true ;
            Notificar(result);
            return false;
        }
    }
}