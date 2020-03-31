using System.Collections.Generic;

namespace Models
{
    public class VehicleTypes
    {
        public const string Car = "Car";
        public const string Motorcycle = "Motorcycle";
        public const string Spaceship = "Spaceship";
        public const string Unicycle = "Unicycle";
        public static IEnumerable<string> TypesList = new List<string>
        {
            Car,
            Motorcycle,
            Spaceship,
            Unicycle
        };
    }
}
