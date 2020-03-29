using System;
using System.Collections.Generic;

namespace Models.Builders
{
    public class FunctionalPersonBuilder : PersonBuilder
    {
        private readonly List<Action<Person>> _actions = new List<Action<Person>>();

        public IList<Action<Person>> Actions => _actions;

        public new Person Build()
        {
            _actions.ForEach(a => a(_person));
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
