// Helicopter: number of rotor blades; 
public class Helicopter : Aircraft
{


    public int NumberRoterBladed { get; set; }
    public double CurrentFuelLevel { get; set; }

    public Helicopter(string model, int yearOfProduction, int numberOfCrewMemembers, int fuelLevel, int numberRoterBladed, double currentFuelLevel)
    : base(model, yearOfProduction, numberOfCrewMemembers, fuelLevel)
    {
        this.NumberRoterBladed = numberRoterBladed;
        this.CurrentFuelLevel = currentFuelLevel;
    }

    public override void MaxFuel()
    {
        FuelLevel = 2000;
    }

    public override string ToString()
    {
        return base.ToString() + $", NumberRoterBladed: {NumberRoterBladed}, CurrentFuelLevel: {CurrentFuelLevel} ";

    }

}