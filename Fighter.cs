
public class Fighter : Aircraft
{

    public FighterType Type { get; set; }

    public Fighter(string model, int yearOfProduction, int numberOfCrewMemembers, int fuelLevel, FighterType type)
    : base(model, yearOfProduction, numberOfCrewMemembers, fuelLevel)
    {
        this.Type = type;

    }

    public override void MaxFuel()
    {
        FuelLevel = 1000;
    }

    public override string ToString()
    {
        return base.ToString() + $", FighterType: {Type}";
    }

}