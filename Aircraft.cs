// Aircraft: model, year of production, number of crew members, fuel level; 
public class Aircraft : IFuelable, IDriveable
{
    

    public string Model { get; set; }
    public int YearOfProduction { get; set; }
    public int NumberOfCrewMemembers { get; set; }  
    public int FuelLevel { get; set; }
    public double CurrentFuelLevel { get ; set ; }
    public double FuelConsumption { get ; set ; }

    public Aircraft(string model, int yearOfProduction, int numberOfCrewMemembers, int fuelLevel)
    {
        this.Model = model;
        this.YearOfProduction = yearOfProduction;
        this.NumberOfCrewMemembers = numberOfCrewMemembers;
        this.FuelLevel = fuelLevel;
    }

    public void Drive(int kilometers)
    {
        double fuelNeeded = kilometers * FuelConsumption;
        if (fuelNeeded >= FuelConsumption)
        {
            fuelNeeded -= FuelConsumption;
        }
        Console.WriteLine("You don't have enough fuel to drive");
    }

    public virtual void MaxFuel(){
        FuelLevel = 2000;
    }

    public override string ToString()
    {
        return base.ToString() + $"Model: {Model}, YearOfProduction:{YearOfProduction}, NumberOfCrewMemembers:{NumberOfCrewMemembers},FuelLevel:{FuelLevel} ";
    }

}