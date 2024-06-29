// Truck: load capacity.

public class Truck : Car
{
    public int LoadCapacity { get; set; }

    public Truck(string brand, string color, int cost, double fuelLevel, int loadCapacity) : base(brand, color, cost, fuelLevel)
    {
        this.LoadCapacity = loadCapacity;
    }
    public override void MaxFuel()
    {
        FuelLevel = 1000;
    }

    public override string ToString()
    {
        return base.ToString() + $", Load Capacity: {LoadCapacity}";
    }
}