public abstract class Machine : IFuelable, IDriveable, IRandomInit
{
    public double CurrentFuelLevel { get;  set ; }
    public double FuelConsumption { get ; set ; }

    public void Drive(int kilometers)
    {
        double fuelNeeded = kilometers * FuelConsumption;
        if(CurrentFuelLevel >= fuelNeeded){
            CurrentFuelLevel = CurrentFuelLevel - fuelNeeded;
        }else
        Console.WriteLine("Not enough fuel to drive the car.");
    }

    public abstract void MaxFuel();

    public virtual void RandomInit(){
        
        // Randomly initialize properties for Machine
        var random = new Random();
        this.CurrentFuelLevel = random.NextDouble() * 100; // Assuming fuel level is between 0 and 100
        this.FuelConsumption = random.NextDouble() * 10; // Assuming fuel consumption is between 0 and 10
    }
    
}