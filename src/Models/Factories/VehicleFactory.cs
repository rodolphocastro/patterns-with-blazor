using Microsoft.Extensions.Logging;

namespace Models.Factories
{
    public class VehicleFactory
    {
        private readonly ILogger<VehicleFactory> _logger;

        public VehicleFactory(ILogger<VehicleFactory> logger = null)
        {
            _logger = logger;
        }

        public Vehicle CreateNewMotorcycle(int id, string make, string model)
        {
            _logger.LogDebug("Creating a new {@VehicleType}: {@make}, {@model}", VehicleTypes.Motorcycle, make, model);
            return new Vehicle { Id = id, Wheels = 2, Make = make, Model = model };
        }

        public Vehicle CreateNewUnicycle(int id, string make, string model)
        {
            _logger.LogDebug("Creating a new {@VehicleType}: {@make}, {@model}", VehicleTypes.Unicycle, make, model);
            return new Vehicle { Id = id, Wheels = 1, Make = make, Model = model };
        }

        public Vehicle CreateNewSpaceship(int id, string make, string model, int? doors = null)
        {
            _logger.LogDebug("Creating a new {@VehicleType}: {@make}, {@model}, {@doors}", VehicleTypes.Spaceship, make, model, doors);
            return new Vehicle { Id = id, Make = make, Model = model, Doors = doors };
        }

        public Vehicle CreateNewCar(int id, string make, string model, int doors = 2)
        {
            _logger.LogDebug("Creating a new {@VehicleType}: {@make}, {@model}, {@doors}", VehicleTypes.Car, make, model, doors);
            return new Vehicle { Id = id, Wheels = 4, Doors = doors, Make = make, Model = model };
        }
    }
}
