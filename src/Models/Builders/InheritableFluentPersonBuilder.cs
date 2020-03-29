using System;

namespace Models.Builders
{
    public class InheritableFluentPersonBuilder<T> : PersonBuilder
        where T : InheritableFluentPersonBuilder<T>
    {
        public T Named(string name)
        {
            _person.Name = name;
            return (T)this;
        }

        public T BornIn(DateTimeOffset? dob)
        {
            _person.DateOfBirth = dob;
            return (T)this;
        }

        public T LivesAt(Address address)
        {
            _person.HomeAddress = address;
            return (T)this;
        }

        public T WorksAt(Address address)
        {
            _person.BusinessAddress = address;
            return (T)this;
        }
    }
}
