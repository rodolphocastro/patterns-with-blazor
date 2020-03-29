namespace Models.Builders
{
    public class FluentAddressBuilder : AddressBuilder
    {
        public FluentAddressBuilder(Address a) : base(a)
        {

        }

        public FluentAddressBuilder()
        {

        }

        public FluentAddressBuilder WithCountry(string country)
        {
            _address.CountryName = country;
            return this;
        }

        public FluentAddressBuilder WithState(string state)
        {
            _address.StateName = state;
            return this;
        }

        public FluentAddressBuilder WithCity(string city)
        {
            _address.CityName = city;
            return this;
        }

        public FluentAddressBuilder WithNumber(int? number)
        {
            _address.Number = number;
            return this;
        }

        public FluentAddressBuilder WithStreet(string street)
        {
            _address.Street = street;
            return this;
        }
    }
}
