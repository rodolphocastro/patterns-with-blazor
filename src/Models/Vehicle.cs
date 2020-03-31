namespace Models
{
    public class Vehicle
    {
        internal Vehicle() { }

        public int Id { get; set; }

        public int? Wheels { get; set; } = null;

        public int? Doors { get; set; } = null;

        public string Make { get; set; }

        public string Model { get; set; }

        public static Vehicle CreateNewMotorcycle(int id, string make, string model) => new Vehicle { Id = id, Wheels = 2, Make = make, Model = model };
        public static Vehicle CreateNewUnicycle(int id, string make, string model) => new Vehicle { Id = id, Wheels = 1, Make = make, Model = model };
        public static Vehicle CreateNewSpaceship(int id, string make, string model, int? doors = null) => new Vehicle { Id = id, Make = make, Model = model, Doors = doors };
        public static Vehicle CreateNewCar(int id, string make, string model, int doors = 2) => new Vehicle { Id = id, Wheels = 4, Doors = doors, Make = make, Model = model };
    }
}
