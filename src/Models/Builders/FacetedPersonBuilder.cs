namespace Models.Builders
{
    public class FacetedPersonBuilder : PersonBuilder
    {
        public FacetedPersonBuilder()
        {
            _person.HomeAddress = new Address();
            _person.BusinessAddress = new Address();
        }
        public FluentPersonBuilder Person => new FluentPersonBuilder(_person);
        public FluentAddressBuilder Lives => new FluentAddressBuilder(_person.HomeAddress);
        public FluentAddressBuilder Works => new FluentAddressBuilder(_person.BusinessAddress);

        public new Person Build()
        {
            _person.HomeAddress = Lives.Build();
            _person.BusinessAddress = Works.Build();
            return base.Build();
        }
    }
}
