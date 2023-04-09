using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace week1Pd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            loginScreenMenu();
            loginNavigation();
            screenMenu();
            navigationScreen();

        }
        static void loginScreenMenu()
        {
            Console.WriteLine("--------login menu -----------");
            Console.WriteLine("1-Sing Up ");
            Console.WriteLine("2-Sing In");
            Console.WriteLine("3-Exit");
        }
        static void loginNavigation()
        {
          
            String[] name = new String[5];
            String[] passwordd = new String[5];
            int totalActiveUser = 0;
            loadLoginDataIntoArray(name, passwordd, ref totalActiveUser); 
            int loginOpt = getOption();
            while(loginOpt!=3)
            {
                if (loginOpt == 1)
                {
                    Console.Clear();
                    singUp(name, passwordd, ref totalActiveUser);
                }
                else if (loginOpt == 2)
                {
                    Console.Clear();
                    singIn(name, passwordd, ref totalActiveUser);
                }
                Console.Clear();
                loginScreenMenu();
                loginOpt = getOption();
            }
           
        }
        static void singUp(String[] name, String[] password, ref int totalActiveUser)
        {

            Console.Write("Enter you name");
            String UName = Console.ReadLine();
            Console.Write("Enter your password ");
            String UPass = Console.ReadLine();
            name[totalActiveUser] = UName;
            password[totalActiveUser] = UPass;
            totalActiveUser++;
            storeLoginDataIntoTheFile(UName, UPass);
            //Console.ReadKey();

        }
        static void singIn(String[] name, String[] password, ref int totalActiveUser)
        {
            bool isExist = false;
            Console.Write("Enter your name");
            String UName = Console.ReadLine();
            Console.Write("Enter your password ");
            String UPass = Console.ReadLine();
            for (int i = 0; i < totalActiveUser; i++)
            {
                if (name[i] == UName && password[i] == UPass)
                {
                    isExist = true;
                }
            }
            if (isExist)
            {
                Console.Write("User Exist ");
                Console.Clear();
                screenMenu();
                navigationScreen();
            }
            else
            {
                Console.Write("user not exist ");
            }
            Console.ReadKey();
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
        static void storeLoginDataIntoTheFile(String name, String password)
        {
            String path = "C:\\Users\\Arbaz khan\\Desktop\\oop-compete-Guide\\week1Pd\\week1Pd\\file.txt";
            StreamWriter file = new StreamWriter(path, true);

            file.WriteLine(name + "," + password);
            file.Flush();
            file.Close();
        }
        static void loadLoginDataIntoArray(String[] name , String[] password, ref int totalUser)
        {
            String path = "C:\\Users\\Arbaz khan\\Desktop\\oop-compete-Guide\\week1Pd\\week1Pd\\file.txt";
            if(File.Exists(path))
            {
                StreamReader file = new StreamReader(path);
                String record;
                while ((record = file.ReadLine()) != null)
                {
                    name[totalUser] = parseData(record, 1);
                    //Console.Write(name[totalUser]);
                    password[totalUser] = parseData(record, 2);
                    Console.Write(password[totalUser]);
                    totalUser++;
                }
                file.Close();
            }
            else
            {
                Console.Write("Path not exist ");
            }
           
        }
        static void storeProductDataIntoFile(string productName, int productPrice, int productQuantity)
        {
            String path = "C:\\Users\\Arbaz khan\\Desktop\\oop-compete-Guide\\week1Pd\\week1Pd\\product.txt";
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(productName + "," + productPrice + "," + productQuantity);
            file.Flush();
            file.Close();
        }

        static void loadProductData(String[] productNames, int[] productPrice, int[] productQuantity, ref int totalProducts)
        {
            String path = "C:\\Users\\Arbaz khan\\Desktop\\oop-compete-Guide\\week1Pd\\week1Pd\\product.txt";
            if (File.Exists(path))
            {
                StreamReader file = new StreamReader(path);
                String record;
                while ((record = file.ReadLine()) != null)
                {
                    productNames[totalProducts] = parseData(record, 1);
                    productPrice[totalProducts] = int.Parse(parseData(record, 2));
                    productQuantity[totalProducts] = int.Parse(parseData(record, 3));
                    totalProducts++;
                }
                file.Close();
            }
            else
            {
                Console.WriteLine("Path does not exist.");
            }
        }

        static String parseData(string data,int line)
        {
            int commaCount = 1;
            String item = "";
            for(int i=0;i<data.Length;i++)
            {
                if (data[i]==',')
                {
                    commaCount++;
                }
                else if(commaCount==line)
                {
                    item += data[i];
                }
            }
            return item;
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
            loadProductData(productNames, productPrice, productQuantity, ref volumeOfArr);


            int opt=getOption();
            while (opt != 5)
            {
                if (opt == 1)
                {
                    createProduct(productNames, productPrice, productQuantity, ref volumeOfArr);
                }
                else if (opt == 2)
                {
                    Console.Clear();
                    getAllProduct(productNames, productPrice, productQuantity,  volumeOfArr);
                }
                else if(opt==4)
                {
                    Console.Clear();
                    deleteProduct(productNames, productPrice, productQuantity, ref volumeOfArr);
                }
                else if(opt==3)
                {
                    Console.Clear();
                    updateProduct(productNames, productPrice, productQuantity, ref volumeOfArr);
                }
                Console.Clear();
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
                storeProductDataIntoFile(Name, price, quantity);


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
            Console.ReadKey();
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
            for(int i=id; i< productName.Length-1;i++)
            {
                string AuxillaryPName = productName[i];
                int AuxillaryPPrice = prodctPrice[i];
                int AuxillaryPQuantity = productQuantity[i];

                productName[i] = productName[i+1];
                productName[i + 1] = AuxillaryPName;

                prodctPrice[i] = prodctPrice[i + 1];
                prodctPrice[i + 1] = AuxillaryPPrice;

                productQuantity[i] = productQuantity[i + 1];
                productQuantity[i + 1] = AuxillaryPPrice;
                
               
            }
            Console.WriteLine("Product is deleted ");
            sizeOfArray--;
            Console.ReadKey();
        }
        static void updateProduct(string[] productName, int[] prodctPrice, int[] productQuantity, ref int sizeOfArray)
        {
            for(int i=0;i<sizeOfArray;i++)
            {
                {
                    Console.WriteLine(i + ": " + productName[i]);
                    Console.WriteLine(i + ": " + prodctPrice[i]);
                    Console.WriteLine(i + ": " + productQuantity[i]);
                }
            }
            Console.Write("Enter the id of the product you want to update ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Enter The Name of the product ");
            String updateProductName = Console.ReadLine();
            Console.Write("Enter the product price ");
            int updatedProductPrice = int.Parse(Console.ReadLine());
            Console.Write("Enter the product quantity ");
            int updatedProductQuantity = int.Parse(Console.ReadLine());
            productName[id] = updateProductName;
            prodctPrice[id] = updatedProductPrice;
            productQuantity[id] = updatedProductQuantity;
            Console.Write("Prodcut Updated ");
            Console.ReadKey();
        }
    }
}
