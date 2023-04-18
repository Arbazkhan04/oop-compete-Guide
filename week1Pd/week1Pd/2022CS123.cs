using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;

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
            Console.WriteLine("1-SignUp ");
            Console.WriteLine("2-SignIn");
            Console.WriteLine("3-Exit");
        }
        static void loginNavigation()
        {

            //String[] name = new String[5];
            // String[] passwordd = new String[5];
            Authentication myObject = new Authentication();
            List<Authentication> auth=new List<Authentication>();
           
            loadLoginDataIntoArray(myObject,auth); 
            int loginOpt = getOption();
            while(loginOpt!=3)
            {
                if (loginOpt == 1)
                {
                    Console.Clear();
                    singUp(myObject,auth);
                }
                else if (loginOpt == 2)
                {
                    Console.Clear();
                    singIn(auth);
                }
                Console.Clear();
                loginScreenMenu();
                loginOpt = getOption();
            }
           
        }
        static void singUp(Authentication obj, List<Authentication> auth)
        {

            Console.Write("Enter you name");
             obj.name = Console.ReadLine();
            Console.Write("Enter your password ");
             obj.password = Console.ReadLine();
            //name[totalActiveUser] = UName;
            //password[totalActiveUser] = UPass;
            //totalActiveUser++;
            storeLoginDataIntoTheFile(obj.name, obj.password);
            auth.Add(obj);
            Console.ReadKey();

        }
        static void singIn(List<Authentication> auth)
        {
            bool isExist = false;
            Console.Write("Enter your name");
            String UName = Console.ReadLine();
            Console.Write("Enter your password ");
            String UPass = Console.ReadLine();
            for (int i = 0; i < auth.Count; i++)
            {
                if (auth[i].name == UName && auth[i].password== UPass)
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
        static void loadLoginDataIntoArray(Authentication myobjec,List<Authentication> auth)
        {
            String path = "C:\\Users\\Arbaz khan\\Desktop\\oop-compete-Guide\\week1Pd\\week1Pd\\file.txt";
            if(File.Exists(path))
            {
                StreamReader file = new StreamReader(path);
                String record;
                while ((record = file.ReadLine()) != null)
                {
                    
                    myobjec.name= parseData(record, 1);
                    //Console.Write(name[totalUser]);
                    myobjec.password = parseData(record, 2);
                    //Console.Write(password[totalUser]);
                    //totalUser++;
                    auth.Add(myobjec);
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

        static void loadProductData(items myobject,List<items> item)
        {
            String path = "C:\\Users\\Arbaz khan\\Desktop\\oop-compete-Guide\\week1Pd\\week1Pd\\product.txt";
            if (File.Exists(path))
            {
                StreamReader file = new StreamReader(path);
                String record;
                while ((record = file.ReadLine()) != null)
                {
                     myobject.productName = parseData(record, 1);
                     myobject.productPrice= int.Parse(parseData(record, 2));
                     myobject.productQuantity = int.Parse(parseData(record, 3));
                     item.Add(myobject);
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
            //int volumeOfArr = 0;
            //string[] productNames = new string[10];
            //int[] productPrice = new int[10];
            //int[] productQuantity = new int[10];
            items itemObject = new items();
            List<items> item = new List<items>(); 
            loadProductData(itemObject,item);


            int opt=getOption();
            while (opt != 5)
            {
                if (opt == 1)
                {
                    createProduct(itemObject,item);
                }
                else if (opt == 2)
                {
                    Console.Clear();
                    getAllProduct(item);
                }
                else if(opt==4)
                {
                    Console.Clear();
                    deleteProduct(item);
                }
                else if(opt==3)
                {
                    Console.Clear();
                    updateProduct(itemObject,item);
                }
                Console.Clear();
                screenMenu();
                opt = getOption();
            }
               
            

        }
        static void createProduct(items myObject,List<items> item)
        {

            Console.WriteLine("------Welcome To the Create Product--------");
            Console.WriteLine("how many product you want to add");
            int numberOfProduct = int.Parse(Console.ReadLine());
            //volumeOfArr += numberOfProduct;//update the lenght of original array

            for (int i = 0; i < numberOfProduct; i++)
            {
                Console.Write("Enter the name of product ");
                 myObject.productName = Console.ReadLine();
                Console.Write("Enter the price for the product ");
                 myObject.productPrice = int.Parse(Console.ReadLine());
                Console.Write("Enter the Number of quantity ");
                 myObject.productQuantity = int.Parse(Console.ReadLine());
                storeProductDataIntoFile(myObject.productName,myObject.productPrice,myObject.productQuantity);
                item.Add(myObject);
               // Console.WriteLine("The product name is {0} and price {1} and quantity {2}", Name, price, quantity);
            }
           foreach(items itema in item)
            {
                Console.WriteLine(itema.productName);
                Console.WriteLine(itema.productPrice);
                Console.WriteLine(itema.productQuantity);
            }
            Console.ReadKey();

        }
        static void getAllProduct(List<items> item)
        {
            Console.WriteLine("--------------All Prodcut-------------");
            //Console.Write(volumeOfPro);
           for(int i=0;i<item.Count;i++)
            {
                Console.WriteLine(i + ": " + item[i].productName);
                Console.WriteLine(i + ": " + item[i].productPrice);
                Console.WriteLine(i + ": " + item[i].productQuantity);

            }
            Console.ReadKey();
        }
        static void deleteProduct(List<items> item)
        {
           // Console.WriteLine(sizeOfArray);
           for(int i=0;i<item.Count;i++)
            {
                Console.WriteLine(i + ": " + item[i].productName);
                Console.WriteLine(i + ": " + item[i].productPrice);
                Console.WriteLine(i + ": " + item[i].productQuantity);
            }
            Console.Write("Enter id of the product you want to delete ");
            int id = int.Parse(Console.ReadLine());
            item.RemoveAt(id);
           
            Console.WriteLine("Product is deleted ");
            Console.ReadKey();
        }
        static void updateProduct(items itemObj,List<items> item)
        {
            for(int i=0;i<item.Count;i++)
            {
                {
                    Console.WriteLine(i + ": " + item[i].productName);
                    Console.WriteLine(i + ": " + item[i].productPrice);
                    Console.WriteLine(i + ": " + item[i].productQuantity);
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
            item[id].productName = updateProductName;
            item[id].productPrice = updatedProductPrice;
            item[id].productQuantity = updatedProductQuantity;
            Console.Write("Prodcut Updated ");
            Console.ReadKey();
        }
    }
}
