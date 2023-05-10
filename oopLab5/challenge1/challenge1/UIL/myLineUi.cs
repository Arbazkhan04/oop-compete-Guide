using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge1.UIL
{
    public  class myLineUi
    {
        public static void getMenu()
        {
            Console.WriteLine("1-Make Line ");
            Console.WriteLine("2-update begin Point");
            Console.WriteLine("3-update end point ");
            Console.WriteLine("4-show the begin point ");
            Console.WriteLine("5-show the end point ");
            Console.WriteLine("6-get the length of the line");
            Console.WriteLine("7-get the gradient of the line ");
            Console.WriteLine("8-Find the ditance fo begin pooint from zero coordinates ");
            Console.WriteLine("Find the distance fo end point form zero coordinatesm ");
            Console.WriteLine("10-Exit");
        }

        public static int getoption()
        {
            Console.WriteLine("Enter option ");
            int opt = int.Parse(Console.ReadLine());
            return opt;
        }
    }


}
