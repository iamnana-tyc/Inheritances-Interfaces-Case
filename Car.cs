// Car: brand, year of production, color, cost, fuel level;
using System.Data.Common;

public class Car : IDriveable, IFuelable, IRandomInit
{

    public string Brand { get; set; }
    public DateTime YearOfProduction { get; set; }

    public string Color { get; set; }

    public int Cost { get; set; }

    public double FuelLevel { get; set; }

    public Car(string brand, string color, int cost, double fuelLevel)
    {
        this.Brand = brand;
        this.Color = color;
        this.Cost = cost;
        this.FuelLevel = fuelLevel;

    }
    public double FuelConsumption { get; set; }
    public double CurrentFuelLevel { get; set; }

    public void Drive(int kilometers)
    {
        double fuelNeeded = kilometers * FuelConsumption;
        if (fuelNeeded >= FuelConsumption)
        {
            FuelLevel = FuelLevel - FuelConsumption;
        }
        Console.WriteLine("You don't have enough fuel to drive");
    }

    public virtual void MaxFuel()
    {

    }

    public override string ToString()
    {
        return $"Brand: {Brand}, YearOfProduction: {YearOfProduction}, Color: {Color}, Cost: {Cost}$, FuelLevel: {FuelLevel}";
    }

    public void RandomInit()
    {
        Random random = new Random();
        Brand = random.GetType().
        throw new NotImplementedException();
    }
}