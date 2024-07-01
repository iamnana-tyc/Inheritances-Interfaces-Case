// Helicopter: number of rotor blades; 
public class Helicopter : Aircraft
{
    public int NumberRoterBladed { get; set; }

  public Helicopter(string model, int yearOfProduction, int numberOfCrewMemembers, int numberRoterBladed )
   : base(model, yearOfProduction, numberOfCrewMemembers)
    {
        this.NumberRoterBladed = numberRoterBladed;
    }

    public Helicopter(){}


    public override void MaxFuel()
    {
        CurrentFuelLevel = 2000;
    }

    public override void RandomInit()
    {
        base.RandomInit();

        Random random = new Random();

        NumberRoterBladed = random.Next(2, 4);

        
    }

    public override string ToString()
    {
        return base.ToString() + $", NumberRoterBladed: {NumberRoterBladed} ";

    }

}