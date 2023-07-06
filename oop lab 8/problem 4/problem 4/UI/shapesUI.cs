using problem_4.BL;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem_4.UI
{
    public class shapesUI
    {
        public static Circle getDataForCircle()
        {
            Console.WriteLine("Enter radius");
            int r = int.Parse(Console.ReadLine());
            Circle c = new Circle(r);
            return c;
            
        }
    }
}
