using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.BL
{
    class Program
    {
        static void Main(string[] args)
        {

            Student1 s1 = new Student1("Kazim", "32kfd", 12.4f, 984, 532, 234, 1, "lahore", true, true);
            float merit = s1.calculateMerit();
            bool isEligible = s1.isEligibleForScholarShip(merit);
            if (isEligible)
            {
                Console.WriteLine("you are eligigble for scholarShip");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("you are not eligible for scholarship ");
                Console.ReadKey();
            }
        }
    }
}
