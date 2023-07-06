using problem_3.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat C1 = new Cat("cat");
            C1.greets();
            C1.ToString();

            Cat C2 = new Cat("cat");
            C2.greets();
            C2.ToString();

            Dog d1 = new Dog("dog");
            d1.greets();
            d1.ToString();

            Console.ReadKey();
        }
    }
}
