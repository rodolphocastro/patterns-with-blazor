using System;

namespace Models.Builders
{
    /// <summary>
    /// Base para os builders de Pessoas.
    /// </summary>
    public abstract class PersonBuilder
    {
        protected Person _person = new Person();

        protected PersonBuilder()
        {

        }

        protected PersonBuilder(Person p)
        {
            _person = p ?? throw new ArgumentNullException(nameof(p));
        }

        public Person Build() => _person;
    }
}
