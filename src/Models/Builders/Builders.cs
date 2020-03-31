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
    }
}
