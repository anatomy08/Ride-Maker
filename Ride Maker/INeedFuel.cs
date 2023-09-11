using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ride_Maker
{
     interface INeedFuel
    {
        
        string FuelType { get; set; }
        int FuelTotal { get; set; }
        void GiveFuel(int Amount);
        
    }
}
