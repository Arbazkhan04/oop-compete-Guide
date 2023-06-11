using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Application.UI
{
    public class MainScreen
    {

        public static void eCommerenceTitle()
        {
            Console.WriteLine("#################################################################################");
            Console.WriteLine("#                         WELCOME TO E-COMMERENCE SHOP                          #");
            Console.WriteLine("#################################################################################");
            Console.WriteLine();
            Console.WriteLine();
        }

        public static int displaySinupAndSinginMenu()
        {
            Console.WriteLine("#########################################################");
            Console.WriteLine("#  Select component you have to see                     #");
            Console.WriteLine("#  1 SingUp                                             #");
            Console.WriteLine("#  2 SingIn                                             #");
            Console.WriteLine("#  3 Exit                                               #");
            Console.WriteLine("#  Select an option                                     #");
            Console.WriteLine("#########################################################");
            Console.Write("Enter option: ");
            int opt = int.Parse(Console.ReadLine());
            return  opt;
        }
  

    }
}
