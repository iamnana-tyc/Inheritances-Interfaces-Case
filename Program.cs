namespace Inheritances_Interfaces_Case;

class Program
{
    static List<Machine> machines = new List<Machine>();
    static void Main(string[] args)
    {
        /*
                // List of Cars
                    List<Car> cars = new List<Car>{
                        new SUV(brand: "Hyundai", color: "Black", cost: 27500, fuelLevel: 500, fourWheelDrive: true, offRoadType: "Hyundai Tucson"),
                        new Truck(brand: "Chevrolet", color: "Blue", cost: 1500, loadCapacity: 5, fuelLevel: 100),
                        new PassengerCar(brand: "Toyota", yearOfProduction: "2010", color: "White", cost: 450, fuelLevel: 550, numberOfSeat: 5, maximumSpeed: 180)
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
         */
/*
        // Testing step 4
        Car car = new Car();
        car.RandomInit();

        Console.WriteLine(car);
*/
        // Step 5 implementation

       

        while (true){
            Console.WriteLine("1. Generate a machine.");
            Console.WriteLine("2. Print All Machines ");
            Console.WriteLine("3. Drive All Machines ");
            Console.WriteLine("4. Fuel All Machines ");
            Console.WriteLine("5. Exit ");

            var choose = Console.ReadLine();

            switch (choose)
            {
                case "1":
                GenerateMachine();
                break;

                case "2":
                PrintAllMachine();
                break;

                case "3":
                DriveAllMachine();
                break;

                case "4":
                FuelAllMachine();
                break;

                case "5":
                return;

                default:
                Console.WriteLine("Invalid choice.");
                    break;
            }
        } 
    }

    // Print all machines 
        static void PrintAllMachine()
        {
            foreach (var machine in machines)
            {
                Console.WriteLine(machine);
            }
        }

        // Drive all machines
        static  void DriveAllMachine(){
            Console.Write("Please enter the Kilometers, ");
            if(int.TryParse(Console.ReadLine(), out int kilometers)){
                foreach(var machine in machines){
                    machine.Drive(kilometers);
                }
            }else
            Console.WriteLine("Please enter kilometers as numeric.");
        }

        static void FuelAllMachine(){
            foreach(var machine in machines){
                machine.MaxFuel();
            }
            Console.WriteLine("All machines are fueled.");
        }


    // Generate A Machine 
        static void GenerateMachine(){
            Console.WriteLine("Please choose the type of machine either Car or Aircraft.");
            var type = Console.ReadLine();

            // we initialise machine
            Machine newMachine = null;
            if(type.Equals("Car", StringComparison.CurrentCultureIgnoreCase)){
                Console.WriteLine("Choose either Car/PassengerCar/Truck/Suv ");
                var subCar = Console.ReadLine();

                switch (subCar)
                {
                    case "Car":
                    newMachine = new Car();
                    break;

                    case "PassengerCar":
                    newMachine = new PassengerCar();
                    break;

                    case "Truck":
                    newMachine = new Truck();
                    break;

                    case "SUV":
                    newMachine = new SUV();
                    break;
                    
                    default:
                    Console.WriteLine("Invalid car type, please make sure you choose correct car type.");
                        break;
                }
            }
            else if(type.Equals("Aircraft", StringComparison.CurrentCultureIgnoreCase)){
                Console.WriteLine("Choose either Aircraft/Airplane/Helicopter/Fighter ");
                var subType = Console.ReadLine();

                switch (subType)
                {
                    case "Aircraft":
                    newMachine = new Aircraft();
                    break;

                    case "Airplane":
                    newMachine = new AirPlane();
                    break;

                    case "Helicopter":
                    newMachine = new Helicopter();
                    break;

                    case "Fighter":
                    newMachine = new Fighter();
                    break;

                    default:
                    Console.WriteLine("Invalid Aircraft type, please make sure you choose correct type.");
                        break;
                }

            }
            else{
                Console.WriteLine("Wrong choosen type.");
                return;
            }

            newMachine.RandomInit();
            machines.Add(newMachine);
            Console.WriteLine("Machines generated successfully!");
            
        }

}
