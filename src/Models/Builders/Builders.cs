using System.Collections.Generic;

namespace Models.Builders
{
    /// <summary>
    /// Shortcut para acessar os builders.
    /// </summary>
    public class Builders
    {
        public const string FluentType = "Fluent";
        public const string FunctionalType = "Functional";
        public static IEnumerable<string> Types => new List<string> { FluentType, FunctionalType };

        public class PersonBuilders
        {
            public static FluentPersonBuilder Fluent => new FluentPersonBuilder();
            public static FunctionalPersonBuilder Functional => new FunctionalPersonBuilder();
        }

        public class AddressBuilders
        {
            public static FluentAddressBuilder Fluent => new FluentAddressBuilder();
            public static FunctionalAddressBuilder Functional => new FunctionalAddressBuilder();
        }
    }
}
