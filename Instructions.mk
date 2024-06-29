Next task: 

Step 1: Implement class hierarchies + interfaces. Bold is the base class, the other classes may be inherited either from base one, or from some class in hierarchy.
- Aircraft, plane, helicopter, fighter;
Aircraft: model, year of production, number of crew members, fuel level; 
Airplane: number of passengers, maximum flight range; 
Helicopter: number of rotor blades; 
Fighter: class (type of the fighter: front-line, interceptor, deck-based, multifunctional, tactical).

- Car, passenger car, SUV, truck;
Car: brand, year of production, color, cost, fuel level, maximum fuel;
Passenger car: number of seats, maximum speed;
SUV: four-wheel drive (logical field), off-road type;
Truck: load capacity.

Step 2: Implement two interfaces for Car and Aircraft: IFuelable and IDriveable. 
- IFuelable has current fuel level attribute and a method MaxFuel. MaxFuel fills fuel to maximum level
- max level should be specific to each element in hierarchy - for example filling Helicopter to max fills 2000 liters, whereas filling Truck fills only 100 liters, for example - specify it in each MaxFuel method for elements of your hierarchy).
- IDriveable has attribute: FuelConsumption (shows amount of liters per kilometer - specify it for each machine in your hierarchy) and method: Drive(int kilometers) - this method should drain fuel and use specific FuelConsumption attribute.
- Override ToString() method for each class (for printing).

Step 3: Test your program (without menu)
- Create a sample list of Cars and a list of Aircrafts, print them.
- Drive all Cars and all Aircrafts, print the result
- MaxFuel all Cars and all Aircrafts, print the result

Step 4. Prepare to making a user-operated program.
- Implement an IRandomInit interface for each element in your hierarchy. It should randomly initialize properties of created instance of the class. Interface has the only method RandomInit that returns void. In implementation of this method inside a class it should randomly initialize all properties for this specific class. You may do base.RandomInit() in the methods of children classes, to init props from base class first, then init props specific for your class afterwards. Final method may be used like Car car = new Car(); - firstly we initialize an instance, then call car.RandomInit(); to generate properties.
- Implement a Machine class. Machine should implement IRandomInit, IFuelable, IDriveable. Make Machine an abstract class and inherit Car and Aircraft from Machine class. 

Step 5. Make a user-operated program:
1. Generate Machine - adds a new machine to a list (attributes are randomly generated - use implemented RandomInit method)
- Choose: Car or Aircraft
- Then choose: Car/PassengerCar/Truck/Suv if user chooses Car; or Aircraft/Airplane/Helicopter/Fighter if user chooses Aircraft
2. Print all machines
3. Drive all machines (calls Drive method of all machines in hierarchy) -> specify amount of kilometers to drive
4. Fuel all machines (calls MaxFuel method of all machines in hierarchy)
5. Exit

Recommendations:
- Implement this task in a separate repository.
- Show your first results after step 3 is finished.