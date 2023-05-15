using Deparmental_Store.BL;
using Deparmental_Store.DL;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deparmental_Store.UI
{
    public  class AdminProductUI
    {
        public static  void  Menu()
        {
           
                Console.WriteLine("--------Menu-----------");
                Console.WriteLine("1-Create Product");
                Console.WriteLine("2-Get All Product");
                Console.WriteLine("3-find all  Product with hihghest price");
                Console.WriteLine("4-view sale daxes of All Product");
                Console.WriteLine("5-product to be oredeed (less than threshole) ");
                Console.WriteLine("6-Exit");
                //          Console.ReadKey();
         
        }

        public static int  getOption()
        {
            Console.WriteLine("Enter your option ");
            int opt = int.Parse(Console.ReadLine());
            return opt;
        }

        public static void navigationForAdmin()
        {
            Menu();
            int opt = getOption();
            while(opt!=6)
            {
                if(opt==1)
                {
                    Console.Clear();
                    addProduct();
                }

                else if(opt==2)
                {
                    Console.Clear();
                    viewAllProduct();
                }

                Console.Clear();
                Menu();
                opt = getOption();
            }
        }

        public static void addProduct()
        {
            Console.WriteLine("Enter name fo product ");
            string productName = Console.ReadLine();

            Console.WriteLine("Enter name fo product qatagory ");
            string qatagory = Console.ReadLine();

            Console.WriteLine("Enter name fo product price ");
            int price = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter name fo product availabe stock quantity ");
            int  availabeStock = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter name fo product threshold Qunatit");
            int thresholdQunatity = int.Parse(Console.ReadLine());

            Product product = new Product(productName, qatagory, price, availabeStock, thresholdQunatity);

            productCrudcs.addProduct(product);
        }

        public static void viewAllProduct()
        {
            List<Product> products = productCrudcs.getAllProductt();

            foreach(Product product in products)
            {
                Console.WriteLine(product.productNAme);
            }

            Console.ReadKey();
        }
    }
}
