// SUV: four-wheel drive (logical field), off-road type;
public class SUV : Car
{
    public Boolean FourWheelDrive { get; set; }
    public string OffRoadType { get; set; }

    public SUV() { }

    public SUV(string brand, string yearOfProduction, string color, int cost, Boolean fourWheelDrive, string offRoadType)
    : base(brand, yearOfProduction, color, cost)
    {
        this.FourWheelDrive = fourWheelDrive;
        this.OffRoadType = offRoadType;
    }

    public override void RandomInit()
    {
        base.RandomInit();

        Random random = new Random();

        string[] offRoadTypes = { "Muddy", "Sandy", "Rocky", "Rallying", "Desert " };

        FourWheelDrive = random.Next(0, 2) == 1;
        OffRoadType = offRoadTypes[random.Next(offRoadTypes.Length)];


    }
    public override void MaxFuel()
    {
       CurrentFuelLevel = 200;
    }
    public override string ToString()
    {
        return base.ToString() + $", FourWheelDrive: {FourWheelDrive}, Off-road type: {OffRoadType} ";

    }
}