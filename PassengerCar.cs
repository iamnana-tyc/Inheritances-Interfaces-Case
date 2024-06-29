public class PassengerCar : Car
{
    public int NumberOfSeat { get; set; }

    public int MaximumSpeed { get; set; }

    public PassengerCar(
        string brand,
        string color,
        int cost,
        double fuelLevel,
        int numberOfSeat,
        int maximumSpeed
    )
        : base(brand, color, cost, fuelLevel)
    {
        this.NumberOfSeat = numberOfSeat;
        this.MaximumSpeed = maximumSpeed;
    }

    public override void MaxFuel()
    {
        FuelLevel = 1000;
    }

    public override string ToString()
    {
        return base.ToString() + $", Seat: {NumberOfSeat}, Max speed: {MaximumSpeed} km/hour ";
    }
}
