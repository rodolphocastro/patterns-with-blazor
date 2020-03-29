namespace Models.Builders
{
    /// <summary>
    /// Shortcut para acessar os builders.
    /// </summary>
    public class Builders
    {
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
