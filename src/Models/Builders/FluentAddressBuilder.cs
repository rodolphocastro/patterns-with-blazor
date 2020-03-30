using Microsoft.Extensions.Logging;

namespace Models.Builders
{
    public class FluentAddressBuilder : AddressBuilder
    {
        private readonly ILogger<FluentAddressBuilder> _logger;

        public FluentAddressBuilder(ILogger<FluentAddressBuilder> logger = null) : base(logger)
        {
            _logger = logger;
        }
        internal FluentAddressBuilder(Address a) : base(a)
        {

        }
        
        public FluentAddressBuilder WithCountry(string country)
        {
            _logger?.LogDebug("Adding {@Field} to {@Address}", country, _address);
            _address.CountryName = country;
            return this;
        }

        public FluentAddressBuilder WithState(string state)
        {
            _logger?.LogDebug("Adding {@Field} to {@Address}", state, _address);
            _address.StateName = state;
            return this;
        }

        public FluentAddressBuilder WithCity(string city)
        {
            _logger?.LogDebug("Adding {@Field} to {@Address}", city, _address);
            _address.CityName = city;
            return this;
        }

        public FluentAddressBuilder WithNumber(int? number)
        {
            _logger?.LogDebug("Adding {@Field} to {@Address}", number, _address);
            _address.Number = number;
            return this;
        }

        public FluentAddressBuilder WithStreet(string street)
        {
            _logger?.LogDebug("Adding {@Field} to {@Address}", street, _address);
            _address.Street = street;
            return this;
        }
    }
}
