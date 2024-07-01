// Car: brand, year of production, color, cost, fuel level;
using System.Data.Common;

public class Car : Machine
{

    public string Brand { get; set; }
    public string YearOfProduction { get; set; }

    public string Color { get; set; }

    public int Cost { get; set; }

    public Car()
    {

    }

    public Car(string brand, string yearOfProduction, string color, int cost)
    {
        this.Brand = brand;
        this.Color = color;
        this.YearOfProduction = yearOfProduction;
        this.Cost = cost;
    }

    public override void MaxFuel()
    {
        CurrentFuelLevel = 100;
    }

    public override void RandomInit()
    {
        // This base.RandomInit() is used to initialize base class properties
        base.RandomInit();

        // now we randomly initialise the props of the Car class
        Random random = new Random();
        string[] brands = { "Toyota", "Skoda", "Ford", "BMW", "Audi" };
        string[] colors = { "Red", "Blue", "Green", "Black", "White" };

        Brand = brands[random.Next(brands.Length)];
        Color = colors[random.Next(colors.Length)];
        YearOfProduction = random.Next(1999, 2024).ToString();
        Cost = random.Next(1000, 200000);


    }

    public override string ToString()
    {
        return $"Brand: {Brand}, YearOfProduction: {YearOfProduction}, Color: {Color}, Cost: {Cost}$ ";
    }
}