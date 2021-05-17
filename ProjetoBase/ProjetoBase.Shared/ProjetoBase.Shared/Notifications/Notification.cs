using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoBase.Shared.Notifications
{
    public class Notification : INotification
    {
        private readonly ICollection<Exception> _exceptions;
        private readonly ICollection<ValidationFailure> _failures;

        public Notification()
        {
            this._exceptions = new List<Exception>();
            this._failures = new List<ValidationFailure>();
        }

        public void AddException(Exception exception) => this._exceptions.Add(exception);

        public void AddFailures(IEnumerable<ValidationFailure> validationFailures)
        {
            foreach (var failure in validationFailures)
                this._failures.Add(failure);
        }

        public void AddFailure(ValidationFailure validationFailure) => _failures.Add(validationFailure);

        public bool HasNotifications() => GetException().Any() || GetFailures().Any();

        public IEnumerable<Exception> GetException() => _exceptions;

        public IEnumerable<ValidationFailure> GetFailures() => this._failures;

    }
}
