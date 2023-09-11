using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ride_Maker
{
    public abstract class  Vehicle
    {
        public string Name { get ; set; }
        public int Passenger {  get; set; }
        public string Color { get; set; }
        public bool Engine {  get; set; }
        public int Topspeed {  get; set; }

        private int DistanceTravel = 0;

        public Vehicle(string name, int passenger, string color, bool engine, int topspeed)
        {
            Name = name;
            Passenger = passenger;
            Color = color;
            Engine = engine;
            Topspeed = topspeed;
        }

        public Vehicle(string name, string color)
        {
            Name = name;
            Passenger = 5;
            Color = color;
            Engine = true;
            Topspeed = 210;
        }

        public void Showinfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Number of Passengers: {Passenger}");
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"Has an Engine: {Engine}");
            Console.WriteLine($"Distance Travelled: {DistanceTravel}");
            Console.WriteLine("******************");
            Console.WriteLine();

        }

        public void Travel(int amount)
        {
            DistanceTravel += amount;
            Console.WriteLine($"Traveled {amount} miles. Total distance travelled: {DistanceTravel}");
        }
    }
}
