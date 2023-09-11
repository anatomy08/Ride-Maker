using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ride_Maker
{
    public class Horse : Vehicle, INeedFuel
    {
        public string FuelType { get; set; }
        public int FuelTotal { get; set; }
        public Horse(string n, int np, string c, int ts, string ft) : base(n, np, c, false, ts)
        {
            FuelType = ft;
            FuelTotal = 10;
        }

        public void GiveFuel(int Amount)
        {
            FuelTotal += Amount;
            Console.WriteLine($"Fueled the {Name} with {FuelType} to {FuelTotal}.");
        }
    }

}       
