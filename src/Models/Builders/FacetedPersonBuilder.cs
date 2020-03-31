
using Microsoft.Extensions.Logging;

namespace Models.Builders
{
    public class FacetedPersonBuilder : PersonBuilder
    {
        private readonly ILogger<FacetedPersonBuilder> _logger;
        private FluentAddressBuilder _homeAddressBuilder;
        private FluentAddressBuilder _businessAddressBuilder;

        public FacetedPersonBuilder(ILogger<FacetedPersonBuilder> logger = null) : base(logger)
        {
            _logger = logger;
        }

        public FluentPersonBuilder Person => new FluentPersonBuilder(_person);
        public FluentAddressBuilder Lives
        {
            get
            {
                if (_person.HomeAddress is null)
                {
                    _person.HomeAddress = new Address();
                    _homeAddressBuilder = new FluentAddressBuilder(_person.HomeAddress);
                }
                return _homeAddressBuilder;
            }
        }
        public FluentAddressBuilder Works
        {
            get
            {
                if (_person.BusinessAddress is null)
                {
                    _person.BusinessAddress = new Address();
                    _businessAddressBuilder = new FluentAddressBuilder(_person.BusinessAddress);
                }

                return _businessAddressBuilder;
            }
        }

        public new Person Build()
        {
            _logger?.LogDebug("Building faceted addresses");
            
            if (_homeAddressBuilder is FluentAddressBuilder)
            {
                _person.HomeAddress = Lives?.Build();
            }

            if (_businessAddressBuilder is FluentAddressBuilder)
            {
                _person.BusinessAddress = Works?.Build();

            }

            return base.Build();
        }

        public new void Clear()
        {
            Person.Clear();
            _person = new Person();
            _homeAddressBuilder = null;
            _businessAddressBuilder = null;
        }
    }
}
