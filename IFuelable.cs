// IFuelable has current fuel level attribute and a method MaxFuel. 
// MaxFuel fills fuel to maximum level - max level should be specific to each element in hierarchy -
// for example filling Helicopter to max fills 2000 liters, whereas filling Truck fills only 100 liters,
// for example - specify it in each MaxFuel method for elements of your hierarchy).
public interface IFuelable
{
    public double CurrentFuelLevel { get; set; }

     void MaxFuel();
}