using System.Collections.Generic;

using Models;

namespace Web.Data
{
    public interface IPeopleService
    {
        public IReadOnlyCollection<Person> People { get; }

        public int AmountOfPeople { get; }

        public void AddPerson(Person newPerson);

        public void RemovePerson(Person person);
    }
}
