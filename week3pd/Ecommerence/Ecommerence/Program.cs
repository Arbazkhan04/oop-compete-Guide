using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            menu();
            navigationScreen();
        }
        static void menu()
        {
            Console.WriteLine("1-Add Product");
            Console.WriteLine("2-view All Product");
            Console.WriteLine("3-find Product wiht highest unit price");
            Console.WriteLine("4-view sales tax of all Product");
            Console.WriteLine("5-poduct to be ordered");
            Console.WriteLine("6-Exit");

        }
        static int option()
        {
            Console.WriteLine("Enter your option");
            int opt = int.Parse(Console.ReadLine());
            return opt;
        }
        static void navigationScreen()
        {
            Product product = new Product();
            List<Product> products = new List<Product>();

            int opt = option();
            while(opt!=6)
            {
                if(opt==1)
                {
                   products.Add(product.addProduct());
                }
              else if(opt==2)
                {
                    viewAllProduct(products);
                }
                opt = option();
            }

        }
    }
}
