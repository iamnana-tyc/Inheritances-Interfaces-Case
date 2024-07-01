// Airplane: number of passengers, maximum flight range; 
public class AirPlane : Aircraft
{
    
    public int NumberOfPassengers { get; set; }
    public int MaximumFlightRange { get; set; }

    public AirPlane(){}

    public AirPlane(string model, int yearOfProduction, int numberOfCrewMemembers, int numberOfPassengers, int maximumFlightRange)
     : base(model, yearOfProduction, numberOfCrewMemembers)
    {
        this.NumberOfPassengers =numberOfPassengers;
        this.MaximumFlightRange = maximumFlightRange;
    }


    public override void RandomInit()
    {
        base.RandomInit();

        Random random = new Random();

        NumberOfPassengers = random.Next(1, 1000);
        MaximumFlightRange = random.Next(1000, 15000);
    }

    public override string ToString()
    {
        return base.ToString() + $", NumberOfPassengers: {NumberOfPassengers}, MaximumFlightRange: {MaximumFlightRange} Km ";
    }

}