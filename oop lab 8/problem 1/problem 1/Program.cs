using problem_1.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Cylinder c1 = new Cylinder();
            Cylinder c2 = new Cylinder(12.425);
            Cylinder c3 = new Cylinder(123.41, 423.3, "red");
        }
    }
}
