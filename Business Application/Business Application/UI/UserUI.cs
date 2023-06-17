using Business_Application.BL;
using Business_Application.DL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
            Console.WriteLine("  5 Trending Product List                              ");
            Console.WriteLine("  6 Change Profile Setting                             ");
            Console.WriteLine("  7 Delete Account                                     ");
            Console.WriteLine("  8 Exit                                              ");
            Console.Write("Enter option: ");

            int opt = ValidationUI.EnterOption(8);
            return opt;

        }


        public static void userNavigationComp()
        {
            int opt = userUiScreen();
            while(opt!=8)
            {
                if(opt==1)
                {
                    AdminUI.viewAllProduct();
                    Console.ReadKey();
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
                else if(opt==5)
                {
                    trendingProduct();
                }
                else if(opt==6)
                {
                    changeProfileSetting();
                }
                else if (opt == 7)
                {
                    deleteUserCrendentials();
                }
                 Console.Clear();
                 opt = userUiScreen();
            }
        }


        public static void buyProduct()
        {
            AdminUI.viewAllProduct();
            Console.Write("Enter the index of the product you want to buy");
            int index = ValidationUI.EnterOption(AdminDL.productList.Count);
            Console.Write("Enter quatnity you wnato to buy ");
            int quantity = ValidationUI.EnterOption(10000);
            if (!(quantity > AdminDL.productList[index].productQuantity))
            {
                Product ExistProduct = ProductDL.getProdcutByIndex(index);
                if (ExistProduct != null)
                {


                    if (ExistProduct.catagory() == "clothes")
                    {
                        Clothes cloth = new Clothes(ExistProduct.productName, ExistProduct.productPrice, quantity);
                        Console.Write("Product Purchased Successfully");
                        UserDL.addPurchasedProduct(cloth);
                        UserDL.storePurchasedProductIntoTheFile(cloth);
                    }
                    else if (ExistProduct.catagory() == "Mobiles")
                    {
                        Mobiles moboile = new Mobiles(ExistProduct.productName, ExistProduct.productPrice, quantity);
                        Console.Write("Product Purchased Successfully");
                        UserDL.addPurchasedProduct(moboile);
                        UserDL.storePurchasedProductIntoTheFile(moboile);
                    }

                    //update the product list as well bexause the quantity is deascreing
                    ProductDL.updateProductListQuantity(index, quantity);
                    ProductDL.storeProductDataIntoTheFile();
                }
           
            }
            else
            {
                Console.Write("Your selected quantity is greatter than availabe quaintiy");
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
                Console.WriteLine("filtered product");
                Console.WriteLine("---------------------------------------------------------------------");
                Console.WriteLine("|   Index   |   Product Name   |   Price   |   Quantity   | Category |");
                Console.WriteLine("---------------------------------------------------------------------");
                for(int i=0;i<products.Count;i++)
                {
                    Product item = products[i];
                    Console.WriteLine($"|   {i,-8} |   {item.productName,-15} |   ${item.productPrice,-7} |   {item.productQuantity,-10} | {item.catagory(),-8} |");
                }
                Console.WriteLine("-----------------------------------------------------------------");

            }

            Console.ReadKey();
        }

        public static void viewCart()
        {

            Console.WriteLine("View Cart");
            Console.WriteLine("------------------------------------------------------------------------------");
            Console.WriteLine("|   Index   |   Product Name   |   Price   |   Quantity   | Category |   Tax   |");
            Console.WriteLine("------------------------------------------------------------------------------");

            if (UserDL.userPurchasedProductList.Count >= 0)
            {
                for (int i = 0; i < UserDL.userPurchasedProductList.Count; i++)
                {
                    Product item = UserDL.userPurchasedProductList[i];
                    Console.WriteLine($"|   {i,-8} |   {item.productName,-15} |   ${item.productPrice,-7} |   {item.productQuantity,-10} | {item.catagory(),-8} |   ${Math.Round(item.taxPerProduct(),2),-5} |");
                }
            }
            else
            {
                Console.WriteLine("your cart is empty ");
            }

            Console.WriteLine("-------------------------------------------------------------");
            Console.ReadKey();
        }

        public static void trendingProduct()
        {
            Console.WriteLine("Trending Product");
            if(UserDL.userPurchasedProductList.Count>3)
            {
                Console.WriteLine("------------------------------------------------------------------------------");
                Console.WriteLine("|   Index   |   Product Name   |   Price   |   Quantity   | Category |   Tax   |");
                Console.WriteLine("------------------------------------------------------------------------------");
                UserDL.userPurchasedProductList.Sort((x, y) => y.productPrice.CompareTo(x.productPrice));//sort the product accoding to the highest price at starting indexs
                for(int i=0;i<UserDL.userPurchasedProductList.Count;i++)

                {
                    if (i > 3)
                    {
                        break;
                    }

                    Product item = UserDL.userPurchasedProductList[i];
                    Console.WriteLine($"|   {i,-8} |   {item.productName,-15} |   ${item.productPrice,-7} |   {item.productQuantity,-10} | {item.catagory(),-8} |   ${Math.Round(item.taxPerProduct(), 2),-5} |");
                }
                Console.WriteLine("-------------------------------------------------------------");


                //buy trending product 
                bool wantToBuy=false;
               Console.WriteLine("Do you want to buy trending product-->(y/n)");
                char getValue = char.Parse(Console.ReadLine());
               wantToBuy = getValue == 'y' ? true : false;
               if(wantToBuy)
                {
                    Console.Write("Enter the index of the product you want to buy");
                    int index = ValidationUI.EnterOption(AdminDL.productList.Count);
                    Product purchaseProduct = UserDL.getTrendingProduct(index);
                    if (purchaseProduct != null)
                    {
                        Console.Write("Successfully Purchased product");
                        UserDL.addPurchasedProduct(purchaseProduct);
                        UserDL.storePurchasedProductIntoTheFile(purchaseProduct);
                    }
                    else
                    {
                        Console.WriteLine("Enter correct index");
                    }
                }
                else
                {
                    Console.WriteLine("okay!");
                }

            }
            else
            {
                Console.WriteLine("nothing in trend");
               
            }
            Console.ReadKey();

        }

        public static void changeProfileSetting()
        {
            Console.Write("Enter your name ");
            string name = Console.ReadLine();
            Console.Write("Enter your password ");
            string password = Console.ReadLine();
            userLogin user = new userLogin(name, password,"user");
           if(SingUpDL.userExist(user))
            {
                UserDL.updateUser(user);
                SingUpDL.storeLoginDataIntoTheFile();//udpate the file
            }
           else
            {
                Console.Write("Enter your correct crendentials");
            }
            Console.ReadKey();

        }

        public static void deleteUserCrendentials()
        {
            Console.Write("Enter your name ");
            string name = Console.ReadLine();
            Console.Write("Enter your password ");
            string password = Console.ReadLine();
            userLogin user = new userLogin(name, password, "user");
            if (SingUpDL.userExist(user))
            {
                UserDL.deleteUserAccount(user);
                SingUpDL.storeLoginDataIntoTheFile();//udpate the file
            }
            else
            {
                Console.Write("Enter your correct crendentials");
            }

            Console.ReadKey();
        }
    }
}
