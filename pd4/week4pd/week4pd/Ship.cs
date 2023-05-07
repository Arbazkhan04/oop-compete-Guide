using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace week4pd
{
    internal class Ship
    {
        public String shipNumber;
        public Angle lattitude;
        public Angle longitude;

        public Ship(string shipNumber, Angle lattitude, Angle longitude)
        {
            this.shipNumber = shipNumber;
            this.lattitude = lattitude;
            this.longitude = longitude;
        }
        public String shipPosition(Angle lattitude,Angle logitutde)
        {
            String pos = $"Ship is at {lattitude.degree}°{lattitude.minutes}'{lattitude.direction} and {logitutde.degree}°{logitutde.minutes}'{logitutde.direction}";
            return pos;
        }
       
    }
}
