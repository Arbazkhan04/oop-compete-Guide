using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace week1Pd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            screenMenu();
            navigationScreen();

        }
        static void  screenMenu()
        {
            Console.WriteLine("--------Menu-----------");
            Console.WriteLine("1-Create Product");
            Console.WriteLine("2-Get All Product");
            Console.WriteLine("3-Update  Product");
            Console.WriteLine("4-Delete Product");
            Console.WriteLine("5-Exit");
//          Console.ReadKey();

        }
        static int getOption()
        {
            Console.WriteLine("Enter your option...");
            int opt = int.Parse(Console.ReadLine());
            return opt; 
        }
        static void navigationScreen()
        {
            int volumeOfArr = 0;
            string[] productNames = new string[10];
            int[] productPrice = new int[10];
            int[] productQuantity = new int[10];
          
            int opt=getOption();
            while (opt != 5)
            {
                if (opt == 1)
                {
                    createProduct(productNames, productPrice, productQuantity, ref volumeOfArr);
                }
                else if (opt == 2)
                {
                    getAllProduct(productNames, productPrice, productQuantity,  volumeOfArr);
                }
                else if(opt==4)
                {
                    deleteProduct(productNames, productPrice, productQuantity, ref volumeOfArr);
                }
                screenMenu();
                opt = getOption();
            }
               
            

        }
        static void createProduct(string[] productname, int[] productPrice, int[] productQuanity, ref int volumeOfArr)
        {

            Console.WriteLine("------Welcome To the Create Product--------");
            Console.WriteLine("how many product you want to add");
            int numberOfProduct = int.Parse(Console.ReadLine());
            volumeOfArr += numberOfProduct;//update the lenght of original array

            for (int i = 0; i < numberOfProduct; i++)
            {
                Console.Write("Enter the name of product ");
                string Name = Console.ReadLine();
                Console.Write("Enter the price for the product ");
                int price = int.Parse(Console.ReadLine());
                Console.Write("Enter the Number of quantity ");
                int quantity = int.Parse(Console.ReadLine());
             

                productname[i] = Name;
                productPrice[i] = price;
                productQuanity[i] = quantity;
               // Console.WriteLine("The product name is {0} and price {1} and quantity {2}", Name, price, quantity);
            }
            for(int i=0;i<numberOfProduct;i++)
            {
                Console.WriteLine(i + ": " + productname[i]);
                Console.WriteLine(i + ": " + productPrice[i]);
                Console.WriteLine(i + ": " + productQuanity[i]);

            }
            Console.ReadKey();

        }
        static void getAllProduct(string[] productName,int[] productPrice, int[] prodctquantity,  int volumeOfPro)
        {
            Console.WriteLine("--------------All Prodcut-------------");
            Console.Write(volumeOfPro);
            for(int i=0;i<volumeOfPro;i++)
            {
                Console.WriteLine(i + ": " + productName[i]);
                Console.WriteLine(i + ": " + productPrice[i]);
                Console.WriteLine(i + ": " + prodctquantity[i]);

            }
        }
        static void deleteProduct(string[] productName, int[] prodctPrice, int[] productQuantity ,ref int sizeOfArray)
        {
           // Console.WriteLine(sizeOfArray);
           for(int i=0;i<sizeOfArray;i++)
            {
                Console.WriteLine(i + ": " + productName[i]);
                Console.WriteLine(i + ": " + prodctPrice[i]);
                Console.WriteLine(i + ": " + productQuantity[i]);
            }
            Console.Write("Enter id of the product you want to delete ");
            int id = int.Parse(Console.ReadLine());
            for(int i=id;i< productName.Length;i++)
            {
                string AuxillaryPName = productName[i];
                int AuxillaryPPrice = prodctPrice[i];
                int AuxillaryPQuantity = productQuantity[i];
            }
            Console.ReadKey();
        }
    }
}
