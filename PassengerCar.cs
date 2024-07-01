public class PassengerCar : Car
{
    public int NumberOfSeat { get; set; }

    public int MaximumSpeed { get; set; }

    public PassengerCar() { }

    public PassengerCar(string brand, string yearOfProduction, string color, int cost, int numberOfSeat, int maximumSpeed)
    : base(brand, yearOfProduction, color, cost)
    {
        this.NumberOfSeat = numberOfSeat;
        this.MaximumSpeed = maximumSpeed;
    }

    public override void RandomInit()
    {
        base.RandomInit();

        Random random = new Random();

        NumberOfSeat = random.Next(2, 5);
        MaximumSpeed = random.Next(100, 250);
    }

    public override void MaxFuel()
    {
        CurrentFuelLevel = 500;
    }

    public override string ToString()
    {
        return base.ToString() + $", Seat: {NumberOfSeat}, Max speed: {MaximumSpeed} km/hour ";
    }

}

