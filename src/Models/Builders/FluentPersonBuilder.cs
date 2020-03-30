using System;
using Microsoft.Extensions.Logging;

namespace Models.Builders
{
    public class FluentPersonBuilder : PersonBuilder
    {
        private readonly ILogger<FluentPersonBuilder> _logger;

        public FluentPersonBuilder(ILogger<FluentPersonBuilder> logger = null) : base(logger)
        {
            _logger = logger;
        }

        internal FluentPersonBuilder(Person p) : base(p)
        {

        }

        public FluentPersonBuilder Named(string name)
        {
            _logger?.LogDebug("Adding {@Field} to {@Person}", name, _person);
            _person.Name = name;
            return this;
        }

        public FluentPersonBuilder BornIn(DateTimeOffset? dob)
        {
            _logger?.LogDebug("Adding {@Field} to {@Person}", dob, _person);
            _person.DateOfBirth = dob;
            return this;
        }

        public FluentPersonBuilder WithAddress(AddressType type, Address address)
        {
            _logger?.LogDebug("Adding {@Field} {@AddressType} to {@Person}", address, type, _person);
            if (type.Equals(AddressType.HomeAddress))
            {
                _person.HomeAddress = address;
            }
            else if (type.Equals(AddressType.BusinessAddress))
            {
                _person.BusinessAddress = address;
            }
            else
            {
                throw new ArgumentException("The supplied AddressType is invalid", nameof(type));
            }

            return this;
        }
    }
}
