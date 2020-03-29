﻿using System;

namespace Models.Builders
{
    public class FluentPersonBuilder : PersonBuilder
    {
        public FluentPersonBuilder()
        {

        }

        public FluentPersonBuilder(Person p) : base(p)
        {

        }
        public FluentPersonBuilder Named(string name)
        {
            _person.Name = name;
            return this;
        }

        public FluentPersonBuilder BornIn(DateTimeOffset? dob)
        {
            _person.DateOfBirth = dob;
            return this;
        }

        public FluentPersonBuilder WithAddress(AddressType type, Address address)
        {
            if (type.Equals(AddressType.HomeAddress))
            {
                _person.HomeAddress = address;
            }
            else if (type.Equals(AddressType.BusinessAddress))
            {
                _person.BusinessAddress = address;
            }
            else
            {
                throw new ArgumentException("The supplied AddressType is invalid", nameof(type));
            }

            return this;
        }
    }
}