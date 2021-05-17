using FluentValidation.Results;
using System;
using System.Collections.Generic;

namespace ProjetoBase.Shared.Notifications
{
    public interface INotification
    {
        void AddException(Exception exception);
        void AddFailure(ValidationFailure validationFailure);
        void AddFailures(IEnumerable<ValidationFailure> validationFailures);
        IEnumerable<Exception> GetException();
        IEnumerable<ValidationFailure> GetFailures();
        bool HasNotifications();
    }
}
