using System.Collections.Generic;

namespace Models.Builders
{
    /// <summary>
    /// Shortcut para acessar os builders.
    /// </summary>
    public partial class Builders
    {
        public const string FluentType = "Fluent";
        public const string FunctionalType = "Functional";
        public const string FacetedType = "Faceted";
        public const string Inheritable = "Inheritable Fluent";
        public static IEnumerable<string> Types => new List<string> { FluentType, FunctionalType, FacetedType, Inheritable };

        public partial class PersonBuilders
        {
            public static FluentPersonBuilder Fluent => new FluentPersonBuilder();
            public static FunctionalPersonBuilder Functional => new FunctionalPersonBuilder();
            public static FacetedPersonBuilder Faceted => new FacetedPersonBuilder();
            public static InheritablePersonBuilder InheritableFluent => new InheritablePersonBuilder();
        }

        public class AddressBuilders
        {
            public static FluentAddressBuilder Fluent => new FluentAddressBuilder();
            public static FunctionalAddressBuilder Functional => new FunctionalAddressBuilder();
        }
    }
}
