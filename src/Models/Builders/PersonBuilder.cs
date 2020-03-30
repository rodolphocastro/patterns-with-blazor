using System;
using Microsoft.Extensions.Logging;

namespace Models.Builders
{
    /// <summary>
    /// Base para os builders de Pessoas.
    /// </summary>
    public abstract class PersonBuilder
    {
        private readonly ILogger<PersonBuilder> _logger;
        protected Person _person = new Person();

        protected PersonBuilder(ILogger<PersonBuilder> logger = null)
        {
            _logger = logger;
        }

        protected PersonBuilder(Person p)
        {
            _person = p ?? throw new ArgumentNullException(nameof(p));
        }

        public Person Build()
        {
            _logger?.LogDebug("Building person {@Person}", _person);
            return _person;
        }

        public void Clear()
        {
            _logger?.LogDebug("Cleaning person {@Person}", _person);
            _person = new Person();
        }
    }
}
