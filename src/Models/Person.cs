using System;

namespace Models
{
    public class Person
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTimeOffset? DateOfBirth { get; set; }

        public Address HomeAddress { get; set; } = null;

        public bool HasHomeAddress => !(HomeAddress is null);

        public Address BusinessAddress { get; set; } = null;

        public bool HasBusinessAddress => !(BusinessAddress is null);
    }
}
