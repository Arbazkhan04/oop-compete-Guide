using problem_4.BL;
using problem_4.UI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle c1 = shapesUI.getDataForCircle();
            Console.WriteLine(c1);
            Console.WriteLine(c1.type());
            Console.ReadKey();
        }
    }
}
