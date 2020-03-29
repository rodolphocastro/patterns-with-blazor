using System.Collections.Generic;
using System.Linq;

using Models;

namespace Web.Data
{
    public class PeopleService : IPeopleService
    {
        private readonly ICollection<Person> _people = new HashSet<Person>();
        public IReadOnlyCollection<Person> People => _people.ToList();

        public int AmountOfPeople => People.Count();

        public void AddPerson(Person newPerson)
        {
            newPerson.Id = People.Count + 1;
            _people.Add(newPerson);
        }

        public void RemovePerson(Person person) => _people.Remove(person);
    }
}
