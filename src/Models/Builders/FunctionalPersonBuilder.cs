using System;
using System.Collections.Generic;

using Microsoft.Extensions.Logging;

namespace Models.Builders
{
    public class FunctionalPersonBuilder : PersonBuilder
    {
        private readonly List<Action<Person>> _actions = new List<Action<Person>>();
        private readonly ILogger<FunctionalPersonBuilder> _logger;

        public IList<Action<Person>> Actions => _actions;

        public FunctionalPersonBuilder(ILogger<FunctionalPersonBuilder> logger = null) : base(logger)
        {
            _logger = logger;
        }

        public new Person Build()
        {
            _actions.ForEach(a =>
            {
                _logger?.LogDebug("Applying action {@Action} to {@Person}", a, _person);
                a(_person);
            });
            return base.Build();
        }
    }

    public static class FunctionalPersonBuilderExtensions
    {
        public static FunctionalPersonBuilder Named(this FunctionalPersonBuilder builder, string name)
        {
            builder.Actions.Add(p => p.Name = name);
            return builder;
        }

        public static FunctionalPersonBuilder BornIn(this FunctionalPersonBuilder builder, DateTimeOffset? dob)
        {
            builder.Actions.Add(p => p.DateOfBirth = dob);
            return builder;
        }

        public static FunctionalPersonBuilder LivesAt(this FunctionalPersonBuilder builder, Address address)
        {
            builder.Actions.Add(p => p.HomeAddress = address);
            return builder;
        }

        public static FunctionalPersonBuilder WorksAt(this FunctionalPersonBuilder builder, Address address)
        {
            builder.Actions.Add(p => p.BusinessAddress = address);
            return builder;
        }
    }
}
