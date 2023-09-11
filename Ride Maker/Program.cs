

using Ride_Maker;

//Vehicle car = new Vehicle("Fortuner", 5 ,"White", true, 160);
//Vehicle motor = new Vehicle("PCX",2 , "Black", true, 120);
//Vehicle bike = new Vehicle("BMX", 2, "Gray", false, 50);
//Vehicle Trycycle = new Vehicle("Russi", 3, "Silver", true, 80);
//Vehicle scooter = new Vehicle("Fazzio", "White Blue");

//List<Vehicle> vehiclelist = new List<Vehicle>();

//vehiclelist.Add(car);
//vehiclelist.Add(motor);
//vehiclelist.Add(bike);
//vehiclelist.Add(Trycycle);
//vehiclelist.Add(scooter);

//foreach (Vehicle vehicle in vehiclelist)
//{
//    vehicle.Showinfo();
//}

//Console.WriteLine();
//motor.Travel(250);
//motor.Showinfo();

Car car = new Car("Honda", 5, "White", 140, "Gas");
Horse horse = new Horse("Stalion", 2, "Black", 70, "Hay");
Bicycle bicycle = new Bicycle("Falcon Cycle", "Silver", 20);

// cannot crate since vehicle is an abstaract now.
//Vehicle scooter = new Vehicle("Scooter", "Black");

List<Vehicle> vehicles = new List<Vehicle>();
vehicles.Add(horse);
vehicles.Add(bicycle);
vehicles.Add(car);

// Create a List of INeedFuel, but do not add anything to it yet
List<INeedFuel> NeedsFuel = new List<INeedFuel>();

foreach (Vehicle v in vehicles)
{
    if(v is INeedFuel)
    {
        NeedsFuel.Add((INeedFuel)v);
    }
}

// Take your finished INeedFuel List, loop through it, and give each item 10 units of fuel
foreach (INeedFuel i in NeedsFuel)
{
    i.GiveFuel(20);
}




