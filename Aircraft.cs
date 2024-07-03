public class Aircraft : Machine
{
    public string Model { get; set; }
    public int YearOfProduction { get; set; }
    public int NumberOfCrewMemembers { get; set; }

    public Aircraft() { }

    public Aircraft(string model, int yearOfProduction, int numberOfCrewMemembers)
    {
        this.Model = model;
        this.YearOfProduction = yearOfProduction;
        this.NumberOfCrewMemembers = numberOfCrewMemembers;
    }

    public override void RandomInit()
    {
        Random random = new Random();

        string[] models = { "Wright Flyer", "Boeing 777 ", "Airbus A380 ", "Boeing 787 Dreamliner", "Lockheed Martin F-35 Lightning II " };

        Model = models[random.Next(models.Length)];
        YearOfProduction = random.Next(1990, 2024);
        NumberOfCrewMemembers = random.Next(1, 15);

    }

    public override void MaxFuel()
    {
        CurrentFuelLevel = 4000;
    }
    public override string ToString()
    {
        return base.ToString() + $"Model: {Model}, YearOfProduction:{YearOfProduction}, NumberOfCrewMemembers:{NumberOfCrewMemembers}, FuelLevel:{CurrentFuelLevel}";
    }


}