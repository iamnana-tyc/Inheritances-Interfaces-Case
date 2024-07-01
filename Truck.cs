// Truck: load capacity.

public class Truck : Car
{
    public int LoadCapacity { get; set; }

    public Truck(string brand, string yearOfProduction, string color, int cost, int loadCapacity) : base(brand, yearOfProduction, color, cost)
    {
        this.LoadCapacity = loadCapacity;
    }

    public Truck() { }

    public override void RandomInit()
    {
        base.RandomInit();

        Random random = new Random();

        LoadCapacity = random.Next(1000, 20000);

    }

    public override void MaxFuel()
    {
        CurrentFuelLevel = 100;
    }

    public override string ToString()
    {
        return base.ToString() + $", Load Capacity: {LoadCapacity} kg";
    }
}