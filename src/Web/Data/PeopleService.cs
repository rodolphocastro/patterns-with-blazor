using System;
using System.Collections.Generic;
using System.Linq;

using Microsoft.Extensions.Logging;

using Models;

namespace Web.Data
{
    public class PeopleService : IPeopleService
    {
        private readonly ICollection<Person> _people = new HashSet<Person>();
        private readonly ILogger<PeopleService> _logger;

        public PeopleService(ILogger<PeopleService> logger)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public IReadOnlyCollection<Person> People => _people.ToList();

        public int AmountOfPeople => People.Count();

        public void AddPerson(Person newPerson)
        {
            newPerson.Id = People.Count + 1;
            _people.Add(newPerson);
            _logger.LogInformation("A new person was created: {@Person}", newPerson);
        }

        public void RemovePerson(Person person)
        {
            _people.Remove(person);
            _logger.LogInformation("A person was removed: {@Person}", person);
        }
    }
}
