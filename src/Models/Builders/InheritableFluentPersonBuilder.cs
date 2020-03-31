using System;

using Microsoft.Extensions.Logging;

namespace Models.Builders
{
    public class InheritableFluentPersonBuilder<T> : PersonBuilder
        where T : InheritableFluentPersonBuilder<T>
    {
        private readonly ILogger<InheritableFluentPersonBuilder<T>> _logger;

        public InheritableFluentPersonBuilder(ILogger<InheritableFluentPersonBuilder<T>> logger = null) : base(logger)
        {
            _logger = logger;
        }

        public T Named(string name)
        {
            _logger?.LogDebug("Adding {@Field} to {@Person}", name, _person);
            _person.Name = name;
            return (T)this;
        }

        public T BornIn(DateTimeOffset? dob)
        {
            _logger?.LogDebug("Adding {@Field} to {@Person}", dob, _person);
            _person.DateOfBirth = dob;
            return (T)this;
        }

        public T LivesAt(Address address)
        {
            _logger?.LogDebug("Adding {@Field} to {@Person}", address, _person);
            _person.HomeAddress = address;
            return (T)this;
        }

        public T WorksAt(Address address)
        {
            _logger?.LogDebug("Adding {@Field} to {@Person}", address, _person);
            _person.BusinessAddress = address;
            return (T)this;
        }
    }
}
