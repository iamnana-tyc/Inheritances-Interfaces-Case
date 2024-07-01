
public class Fighter : Aircraft
{
    
    public FighterType Type { get; set; }

   public Fighter(string model, int yearOfProduction, int numberOfCrewMemembers, FighterType type)
    : base(model, yearOfProduction, numberOfCrewMemembers)
    {
        this.Type = type;
    }

    public Fighter(){}

    public override void MaxFuel()
    {
        CurrentFuelLevel = 1000;
    }

    public override void RandomInit()
    {
        base.RandomInit();
        Random random = new Random();

        Array fighterTypes = Enum.GetValues(typeof(FighterType));
        Type = (FighterType)fighterTypes.GetValue(random.Next(fighterTypes.Length));

    }

    public override string ToString()
    {
        return base.ToString() + $", FighterType: {Type}";
    }

}