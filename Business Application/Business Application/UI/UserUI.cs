using Business_Application.BL;
using Business_Application.DL;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Business_Application.UI
{
    public class UserUI
    {
        public static int userUiScreen()
        {
            Console.WriteLine("\n");
            Console.WriteLine("**********************************************************************");
            Console.WriteLine($"              Welcome To The User Panel                              ");
            Console.WriteLine("**********************************************************************");
            Console.WriteLine("  1 View Product                                       ");
            Console.WriteLine("  2 Buy product                                        ");
            Console.WriteLine("  3 filter product                                     ");
            Console.WriteLine("  4 View Cart                                          ");
            Console.WriteLine("  5 Add to Cart                                        ");
            Console.WriteLine("  7 Trending Product List                              ");
            Console.WriteLine("  8 Change Profile Setting                             ");
            Console.WriteLine("  9 Delete Account                                     ");
            Console.WriteLine("  10 Exit                                              ");
            Console.Write("Enter option: ");

            int opt = int.Parse(Console.ReadLine());
            return opt;

        }


        public static void userNavigationComp()
        {
            int opt = userUiScreen();
            while(opt!=10)
            {
                if(opt==1)
                {
                    AdminUI.viewAllProduct();
                }
                else if(opt==2)
                {
                    buyProduct();
                }
                else if(opt==3)
                {
                    filterProduct();
                }
                else if(opt==4)
                {
                    viewCart();
                }
                 Console.Clear();
                 opt = userUiScreen();
            }
        }


        public static void buyProduct()
        {
            AdminUI.viewAllProduct();
            Console.Write("Enter the index of the product you want to buy");
            int index = int.Parse(Console.ReadLine());
            Product purchaseProduct = ProductDL.getProdcutByIndex(index);
            if(purchaseProduct!=null)
            {
                Console.WriteLine(purchaseProduct.productName + purchaseProduct.productPrice + purchaseProduct.productQuantity);
                 UserDL.addPurchasedProduct(purchaseProduct);

            }

            Console.ReadKey();


        }

       public static void filterProduct()
        {
            Console.WriteLine("Enter the name of the product you want to search ");
            string name = Console.ReadLine();
            List<Product> products = ProductDL.filterProduct(name);
            
            if(products.Count>=0)
            {
                foreach(Product p in products)
                {
                    Console.WriteLine(p.productName+p.productPrice+p.productQuantity);

                }
            }

            Console.ReadKey();
        }

        public static void viewCart()
        {

            Console.WriteLine("View Cart");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("|   Index   |   Product Name   |   Price   |   Quantity   |");
            Console.WriteLine("----------------------------------------------------------");

            if(UserDL.userPurchasedProductList.Count>=0)
            {
                for (int i = 0; i < UserDL.userPurchasedProductList.Count; i++)
                {
                    Product item = UserDL.userPurchasedProductList[i];
                    Console.WriteLine($"|   {i,-8} |   {item.productName,-15} |   ${item.productPrice,-7} |   {item.productQuantity,-10} |");
                }

            }
            else
            {
                Console.WriteLine("your cart is empty ");
            }

            Console.WriteLine("-------------------------------------------------------------");
            Console.ReadKey();
        }
    }
}
