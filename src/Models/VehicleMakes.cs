using System.Collections.Generic;

namespace Models
{
    public static class VehicleMakes
    {
        private const string _renault = "Renault";
        private const string _chevy = "Chevrolet";
        private const string _wolks = "Volkswagen";
        private const string _ford = "Ford";
        private const string _tesla = "Tesla";
        private const string _honda = "Honda";
        private const string _harley = "Harley Davidson";
        private const string _kawasaki = "Kawasaki Motors";

        public static IEnumerable<string> Makes => new List<string>
        {
            _renault,
            _chevy,
            _wolks,
            _ford,
            _tesla,
            _honda,
            _harley,
            _kawasaki
        };
    }
}
