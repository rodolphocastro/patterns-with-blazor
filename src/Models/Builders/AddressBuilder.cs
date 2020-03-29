using System;

namespace Models.Builders
{
    /// <summary>
    /// Base para os builders de Address.
    /// </summary>
    public abstract class AddressBuilder
    {
        protected Address _address = new Address();

        protected AddressBuilder()
        {

        }

        protected AddressBuilder(Address a)
        {
            _address = a ?? throw new ArgumentNullException(nameof(a));
        }

        public Address Build() => _address;
    }
}
