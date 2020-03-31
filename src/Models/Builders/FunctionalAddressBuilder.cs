using System;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;

namespace Models.Builders
{
    public class FunctionalAddressBuilder : AddressBuilder
    {
        protected readonly List<Action<Address>> _actions = new List<Action<Address>>();
        private readonly ILogger<FunctionalAddressBuilder> _logger;

        public FunctionalAddressBuilder(ILogger<FunctionalAddressBuilder> logger = null) : base(logger)
        {
            _logger = logger;
        }

        public IList<Action<Address>> Actions => _actions;

        public new Address Build()
        {
            _actions.ForEach(a =>
            {
                _logger?.LogDebug("Applying action {@Action} to {@Address}", a, _address);
                a(_address);
            });
            return base.Build();
        }
    }

    public static class FunctionalAddressBuilderExtensions
    {
        public static FunctionalAddressBuilder AtStreet(this FunctionalAddressBuilder builder, string street)
        {
            builder.Actions.Add(a => a.Street = street);
            return builder;
        }

        public static FunctionalAddressBuilder AtNumber(this FunctionalAddressBuilder builder, int? number)
        {
            builder.Actions.Add(a => a.Number = number);
            return builder;
        }

        public static FunctionalAddressBuilder AtCity(this FunctionalAddressBuilder builder, string city)
        {
            builder.Actions.Add(a => a.CityName = city);
            return builder;
        }

        public static FunctionalAddressBuilder AtState(this FunctionalAddressBuilder builder, string state)
        {
            builder.Actions.Add(a => a.StateName = state);
            return builder;
        }

        public static FunctionalAddressBuilder AtCountry(this FunctionalAddressBuilder builder, string country)
        {
            builder.Actions.Add(a => a.CountryName = country);
            return builder;
        }
    }
}