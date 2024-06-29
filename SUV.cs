// SUV: four-wheel drive (logical field), off-road type;
public class SUV : Car
{
    public Boolean FourWheelDrive { get; set; }
    public string OffRoadType { get; set; }


    public SUV(string brand, string color, int cost, double fuelLevel, Boolean fourWheelDrive, string offRoadType)
    : base(brand, color, cost, fuelLevel)
    {
        this.FourWheelDrive = fourWheelDrive;
        this.OffRoadType = offRoadType;
    }

    public override void MaxFuel()
    {
        FuelLevel = 1000;
    }
    public override string ToString()
    {
        return base.ToString() + $", FourWheelDrive: {FourWheelDrive}, Off-road type: {OffRoadType} ";

    }
}