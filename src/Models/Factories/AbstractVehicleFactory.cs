using Microsoft.Extensions.Logging;

namespace Models.Factories
{
    public class AbstractVehicleFactory
    {
        private readonly ILogger<AbstractVehicleFactory> _logger;

        public AbstractVehicleFactory(ILogger<AbstractVehicleFactory> logger = null)
        {
            _logger = logger;
        }

        public IVehicle CreateNewMotorcycle(int id, string make, string model)
        {
            _logger.LogDebug("Creating a new {@VehicleType}: {@make}, {@model}", VehicleTypes.Motorcycle, make, model);
            return new Vehicle { Id = id, Wheels = 2, Make = make, Model = model };
        }

        public IVehicle CreateNewUnicycle(int id, string make, string model)
        {
            _logger.LogDebug("Creating a new {@VehicleType}: {@make}, {@model}", VehicleTypes.Unicycle, make, model);
            return new Vehicle { Id = id, Wheels = 1, Make = make, Model = model };
        }

        public IVehicle CreateNewSpaceship(int id, string make, string model, int? doors = null)
        {
            _logger.LogDebug("Creating a new {@VehicleType}: {@make}, {@model}, {@doors}", VehicleTypes.Spaceship, make, model, doors);
            return new Vehicle { Id = id, Make = make, Model = model, Doors = doors };
        }

        public IVehicle CreateNewCar(int id, string make, string model, int doors = 2)
        {
            _logger.LogDebug("Creating a new {@VehicleType}: {@make}, {@model}, {@doors}", VehicleTypes.Car, make, model, doors);
            return new Vehicle { Id = id, Wheels = 4, Doors = doors, Make = make, Model = model };
        }
    }
}
