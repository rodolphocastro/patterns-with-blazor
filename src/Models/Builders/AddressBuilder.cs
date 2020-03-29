namespace Models.Builders
{
    /// <summary>
    /// Base para os builders de Address.
    /// </summary>
    public abstract class AddressBuilder
    {
        protected Address _address = new Address();

        public Address Build() => _address;
    }
}
