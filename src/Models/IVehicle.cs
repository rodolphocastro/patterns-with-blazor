namespace Models
{
    public interface IVehicle
    {
        int? Doors { get; set; }
        int Id { get; set; }
        string Make { get; set; }
        string Model { get; set; }
        int? Wheels { get; set; }

        void Drive();
    }
}