using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerence
{
    internal class Product
    {
        public string productName;
        public int price;
        public string productCatagory;
        public int stockQuantity;
        public int minQuantity;

        public Product(string protName,int ppice,string pCatagory,int sQuantity,int mQuantity)
        {
            productName = protName;
            price = ppice;
            productCatagory = pCatagory;
            stockQuantity = sQuantity;
            minQuantity = mQuantity;

        }
        public Product()
        {

        }
        public Product addProduct()
        {
            Console.WriteLine("Enter the name of the product");
            String pName = Console.ReadLine();
            Console.WriteLine("Enter the price for the product");
            int Price = int.Parse(Console.ReadLine());
            Console.WriteLine("choose your catogory");
            String pCatagory = Console.ReadLine();
            Console.Write("Enter the Qantity");
            int StockQuantity = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the minimum quantity");
            int mQuantity = int.Parse(Console.ReadLine());
            Console.WriteLine("product added successfully");

            Product newProdcut=new Product(pName, Price, pCatagory, StockQuantity, mQuantity);
            return newProdcut;
        }

        public void viewAllProduct(List<Product> p)
        {

        }

    }
   
  
}
