using Business_Application.BL;
using Business_Application.DL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
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
            while(opt!=11)
            {
                if(opt==1)
                {
                    createProduct();
                }
                else if(opt==2)
                {
                    updateProduct();
                }
                else if(opt==3)
                {
                    deleteProduct();
                }
                else if(opt==4)
                {
                    viewAllProduct();
                }
                Console.Clear();
                 opt = adminMenu();
            }
        }

        public static void createProduct()
        {
            Console.Write("How many product you want to enter ");
            int count = int.Parse(Console.ReadLine());
            for(int i=count;i>0 ;i--)
            {
                Product p = ProductUI.getInputForProduct();
                ProductDL.addProduct(p);
            }

        }

        public static void updateProduct()
        {
            Product updatedProduct = ProductUI.updateProduct();
            if(ProductDL.checkProductExist(updatedProduct))
            {
                ProductDL.upDateProduct(updatedProduct);
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
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("|   Index   |   Product Name   |   Price   |   Quantity   |");
            Console.WriteLine("----------------------------------------------------------");

            for (int i = 0; i < AdminDL.productList.Count; i++)
            {
                Product item = AdminDL.productList[i];
                Console.WriteLine($"|   {i,-8} |   {item.productName,-15} |   ${item.productPrice,-7} |   {item.productQuantity,-10} |");
            }

            Console.WriteLine("-----------------------------------------------------");
            Console.ReadKey();
        }


    }
}
