using Business_Application.BL;
using Business_Application.DL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Business_Application.UI
{
    public class AdminUI
    {
        public static int adminMenu()
        {
            Console.WriteLine("\n \n");
            Console.WriteLine("**********************************************************************");
            Console.WriteLine("              Welcome To The Admin Panel                              ");
            Console.WriteLine("**********************************************************************");
            Console.WriteLine("  1 Create Product                                     ");
            Console.WriteLine("  2 Update Product                                     ");
            Console.WriteLine("  3 Delete Product                                     ");
            Console.WriteLine("  4 View All Product                                   ");
            Console.WriteLine("  5 Total Sold Product                                 ");
            Console.WriteLine("  6 Total User List                                    ");
            Console.WriteLine("  7 Product Analystics                                 ");
            Console.WriteLine("  8 Product Detail                                     ");
            Console.WriteLine("  9 Change Profile Setting                             ");
            Console.WriteLine("  10 Delete Account                                    ");
            Console.WriteLine("  11 Exit                                              ");
            Console.Write("Enter option: ");

            int opt = int.Parse(Console.ReadLine());
            return opt;
        }

        public static void adminNavigateComp()
        {
            int opt = adminMenu();
            while (opt != 11)
            {
                if (opt == 1)
                {
                    createProduct();
                }
                else if (opt == 2)
                {
                    updateProduct();
                }
                else if (opt == 3)
                {
                    deleteProduct();
                }
                else if (opt == 4)
                {
                    viewAllProduct();
                }
                else if (opt == 5)
                {
                    totalSoldProduct();
                }
                Console.Clear();
                opt = adminMenu();
            }
        }

        public static void createProduct()
        {
            Console.Write("How many product you want to enter ");
            int count = int.Parse(Console.ReadLine());
            Console.Write("Select Catagory(1-clothes,2-Mobile)");
            int catagory = int.Parse(Console.ReadLine());

            for (int i = count; i > 0; i--)
            {
                if (catagory == 1)
                {
                    Clothes clothes = ClothUI.getInputForProduct();
                    ProductDL.addProduct(clothes);
                   
                }
                else if (catagory == 2)
                {
                    Mobiles mobile = MobileUI.getInputForProduct();
                    ProductDL.addProduct(mobile);
                    
                }
                else
                {
                    Console.Write("Enter correct catagory ");
                }
            }
            ProductDL.storeProductDataIntoTheFile();//sotre all the object into the file

        }

        public static void updateProduct()
        {
            Product updatedProduct = ProductUI.updateProduct();
            if (ProductDL.checkProductExist(updatedProduct))
            {
                ProductDL.upDateProduct(updatedProduct);
                ProductDL.storeProductDataIntoTheFile();
                Console.WriteLine("Product updated successfully ");
            }
            else
            {
                Console.WriteLine("Product does not exist ");
            }

            Console.ReadKey();
        }

        public static void deleteProduct()
        {
            Product deleteProduct = ProductUI.delteProduct();
            if (ProductDL.checkProductExist(deleteProduct))
            {
                ProductDL.deleteProduct(deleteProduct);
                ProductDL.storeProductDataIntoTheFile();
                Console.WriteLine("Product delledted successfully ");
            }
            else
            {
                Console.WriteLine("Product does not exist ");
            }
            Console.ReadKey();
        }

        public static void viewAllProduct()
        {
            Console.WriteLine("All Products:");
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("|   Index   |   Product Name   |   Price   |   Quantity   | Category |");
            Console.WriteLine("---------------------------------------------------------------------");

            for (int i = 0; i < AdminDL.productList.Count; i++)
            {
                Product item = AdminDL.productList[i];
                Console.WriteLine($"|   {i,-8} |   {item.productName,-15} |   ${item.productPrice,-7} |   {item.productQuantity,-10} | {item.catagory(),-8} |");
            }

            Console.WriteLine("---------------------------------------------------------------------");
            Console.ReadKey();
        }

        public static void totalSoldProduct()
        {

            double tax = 0.0F;
            int totalPrice = 0;
            Console.WriteLine("Total Sold Products:");
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("|   Index   |   Product Name   |   Price   |   Quantity   | Category |");
            Console.WriteLine("---------------------------------------------------------------------");

            for (int i = 0; i < UserDL.userPurchasedProductList.Count; i++)
            {
                Product item = AdminDL.productList[i];
                Console.WriteLine($"|   {i,-8} |   {item.productName,-15} |   ${item.productPrice,-7} |   {item.productQuantity,-10} | {item.catagory(),-8} |");
                tax += item.taxPerProduct();
                totalPrice += item.productPrice;

            }

            double reveue = tax + totalPrice;

            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("|                 Total Revenue Generated =" + Math.Round(reveue, 2));
            Console.WriteLine("---------------------------------------------------------------------");

            Console.WriteLine("---------------------------------------------------------------------");
            Console.ReadKey();
        }
    }
}

 
