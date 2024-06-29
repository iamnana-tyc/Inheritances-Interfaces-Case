namespace Inheritances_Interfaces_Case;

class Program
{
    static void Main(string[] args)
    {

        // List of Cars
            List<Car> cars = new List<Car>{
                new SUV(brand: "Hyundai", color: "Black", cost: 27500, fuelLevel: 500, fourWheelDrive: true, offRoadType: "Hyundai Tucson"),
                new Truck(brand: "Chevrolet", color: "Blue", cost: 1500, loadCapacity: 5, fuelLevel: 100),
                new PassengerCar(brand: "Toyota", color: "White", cost: 450, fuelLevel: 550, numberOfSeat: 5, maximumSpeed: 180)
            };


        Console.WriteLine("These are the cars");
        foreach (var car in cars)
        {
            Console.WriteLine(car);
        }

        // List of Aircraft
        List<Aircraft> aircrafts = new List<Aircraft>{
        new Fighter(model: "Hogan", yearOfProduction: 2018, numberOfCrewMemembers: 2, fuelLevel: 20, FighterType.FrontLine),
        new AirPlane(model: "Boeing 737", yearOfProduction: 1999, numberOfCrewMemembers: 7, fuelLevel: 50, numberOfPassengers: 100, maximumFlightRange: 10),
        new Helicopter(model: "MI-17", yearOfProduction: 2014, numberOfCrewMemembers: 8, fuelLevel: 19, numberRoterBladed: 4, currentFuelLevel: 1000)
       };

        Console.WriteLine();

        Console.WriteLine("These are the Aircrafts");
        foreach (var aircraft in aircrafts)
        {
            Console.WriteLine(aircraft);
        }

        Console.WriteLine();

        // Drive all Cars and all Aircrafts, print the result
        Console.WriteLine("Driving all cars");
        foreach(var car in cars){
            car.Drive(100);
            Console.WriteLine(car);
        }

        Console.WriteLine();

        foreach(var aircraft in aircrafts){
            aircraft.Drive(100);
            Console.WriteLine(aircraft);
        }
      
        Console.WriteLine();

        // MaxFuel all Cars and all Aircrafts, print the result
        Console.WriteLine("MaxFueling all cars");
         foreach(var car in cars){
            car.MaxFuel();
            Console.WriteLine(car);
        }

        Console.WriteLine();
        
        Console.WriteLine("MaxFueling all aircrafts");
         foreach(var aircraft in aircrafts){
            aircraft.MaxFuel();
            Console.WriteLine(aircraft);
        }
    }
}
