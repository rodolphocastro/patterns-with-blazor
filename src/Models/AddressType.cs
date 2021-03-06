﻿using System;
using System.Collections.Generic;

namespace Models
{
    public class AddressType : IEquatable<AddressType>
    {
        private const string _homeAddress = "Home";
        private const string _businessAddress = "Business";

        private AddressType(string value) => Value = value;

        public string Value { get; }

        public static AddressType HomeAddress => new AddressType(_homeAddress);

        public static AddressType BusinessAddress => new AddressType(_businessAddress);

        public static implicit operator string(AddressType a) => a.Value;
        public static implicit operator AddressType(string s)
        {
            if (s.Equals(_homeAddress, StringComparison.InvariantCultureIgnoreCase))
            {
                return HomeAddress;
            }
            else if (s.Equals(_businessAddress, StringComparison.InvariantCultureIgnoreCase))
            {
                return BusinessAddress;
            }

            throw new InvalidCastException($"The string {s} cannot be cast to AddressType");
        }

        public override bool Equals(object obj) => Equals(obj as AddressType);
        public bool Equals(AddressType other) => other != null && Value == other.Value;
        public override int GetHashCode() => -1937169414 + EqualityComparer<string>.Default.GetHashCode(Value);
    }
}
