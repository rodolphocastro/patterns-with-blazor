using System;
using Microsoft.Extensions.Logging;

namespace Models.Builders
{
    /// <summary>
    /// Base para os builders de Address.
    /// </summary>
    public abstract class AddressBuilder
    {
        private readonly ILogger<AddressBuilder> _logger;
        protected Address _address = new Address();

        protected AddressBuilder(ILogger<AddressBuilder> logger = null)
        {
            _logger = logger;
        }

        protected AddressBuilder(Address a)
        {
            _address = a ?? throw new ArgumentNullException(nameof(a));
        }

        public Address Build()
        {
            _logger?.LogDebug("Building address {@Address}", _address);
            return _address;
        }

        public void Clear()
        {
            _logger?.LogDebug("Cleaning address {@Address}", _address);
            _address = new Address();
        }
    }
}
