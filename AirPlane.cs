// Airplane: number of passengers, maximum flight range; 
public class AirPlane : Aircraft
{

    public int NumberOfPassengers { get; set; }
    public int MaximumFlightRange { get; set; }

    public AirPlane(string model, int yearOfProduction, int numberOfCrewMemembers, int fuelLevel, int numberOfPassengers, int maximumFlightRange)
    : base(model, yearOfProduction, numberOfCrewMemembers, fuelLevel)
    {
        this.NumberOfPassengers = numberOfPassengers;
        this.MaximumFlightRange = maximumFlightRange;
    }

    public override string ToString()
    {
        return base.ToString() + $", NumberOfPassengers: {NumberOfPassengers}, MaximumFlightRange: {MaximumFlightRange} ";
    }

}