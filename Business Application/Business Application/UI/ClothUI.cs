using Business_Application.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Application.UI
{
    public class ClothUI
    {
        public static Clothes getInputForProduct()
        {
            Console.Write("Enter the name of the product ");
            string pName = Console.ReadLine();

            Console.Write("Enter product price");
            int pPrice = int.Parse(Console.ReadLine());

            Console.Write("Enter product Quantity");
            int pQuantity = int.Parse(Console.ReadLine());

            Clothes p = new Clothes(pName, pPrice, pQuantity);

            return p;

        }
    }
}
