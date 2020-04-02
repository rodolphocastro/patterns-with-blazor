namespace Models
{
    public interface IDriveable
    {
        int? Wheels { get; }
        int? Doors { get; }

        void Drive();
    }
}