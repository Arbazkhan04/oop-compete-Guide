using Business_Application.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Application.UI
{
    public class ProductUI
    {
        public static Product  updateProduct()
        {
            Console.Write("Enter the name of the updated product ");
            string pName = Console.ReadLine();

            Console.Write("Enter  price for update product");
            int pPrice = ValidationUI.EnterOption(10000);

            Console.Write("Enter  Quantity for update product");
            int pQuantity = ValidationUI.EnterOption(10000);

            Product p = new Product(pName, pPrice, pQuantity);

            return p;
        }

        public static Product delteProduct()
        {
            Console.Write("Enter the name of the deleted product ");
            string pName = Console.ReadLine();

            Console.Write("Enter  price for deleted product");
            int pPrice = ValidationUI.EnterOption(10000);

            Console.Write("Enter  Quantity for deleted product");
            int pQuantity = ValidationUI.EnterOption(10000);

            Product p = new Product(pName, pPrice, pQuantity);

            return p;
        }
    }
}
