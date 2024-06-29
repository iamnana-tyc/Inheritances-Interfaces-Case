// IDriveable has attribute: FuelConsumption (shows amount of liters per kilometer - specify it for each machine in your hierarchy) 
// and method: Drive(int kilometers) - this method should drain fuel and use specific FuelConsumption attribute.
public interface IDriveable
{
    public double FuelConsumption { get; set; }

    void Drive(int kilometers);
    
}