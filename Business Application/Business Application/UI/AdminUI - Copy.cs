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

            int opt =ValidationUI.EnterOption(11);
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
                    Console.ReadKey();
                }
                else if (opt == 5)
                {
                    totalSoldProduct();
                }
                else if(opt==6)
                {
                    totalUserList();
                }
                else if(opt==7)
                {
                    productAnalystics();
                }
                else if(opt==8)
                {
                    productDetail();
                }

                else if(opt==9)
                {
                    changeProfileSetting();
                }
                else if(opt==10)
                {
                    deeteAdmin();
                }
                Console.Clear();
                opt = adminMenu();
            }
        }

        public static void createProduct()
        {
           
            Console.Write("How many product you want to enter ");
            int count = ValidationUI.EnterOption(10);
            Console.Write("Select Catagory(1-clothes,2-Mobile)");
            int catagory = ValidationUI.EnterOption(2);

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
            Console.Clear();
            viewAllProduct();
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
                Console.WriteLine($"|   {i,-8} |   {item.getProductName(),-15} |   ${item.getProductPrice(),-7} |   {item.getproductQuantity(),-10} | {item.catagory(),-8} |");
            }

            Console.WriteLine("---------------------------------------------------------------------");
           
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
                Console.WriteLine($"|   {i,-8} |   {item.getProductName(),-15} |   ${item.getProductPrice(),-7} |   {item.getproductQuantity(),-10} | {item.catagory(),-8} |");
                tax += item.taxPerProduct();
                totalPrice += item.getProductPrice();

            }

            double reveue = tax + totalPrice;

            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("|                 Total Revenue Generated =" + Math.Round(reveue, 2));
            Console.WriteLine("---------------------------------------------------------------------");

            Console.WriteLine("---------------------------------------------------------------------");
            Console.ReadKey();
        }

        public static void totalUserList()
        {
            if(SingUpDL.userList.Count>0)
            {
                Console.WriteLine("Total user list:");
                Console.WriteLine("----------------------------------------------------------------");
                Console.WriteLine("|   Index   |   user Name   |   user password   |   user Role  |");
                Console.WriteLine("----------------------------------------------------------------");

               for(int i=0;i<SingUpDL.userList.Count;i++)
                {
                    SingUp user = SingUpDL.userList[i];
                    Console.WriteLine($"|   {i,-8} |   {user.getName(),-15} |   {user.getPassword(),-7} |   {user.getRole(),-10} |");

                }
                Console.WriteLine("-----------------------------------------------------------------");
            }
            else
            {
                Console.WriteLine("No user !");
            }

            Console.ReadKey();
        }

        public static void productAnalystics()
        {
            //start form here
            Console.Clear();
            Console.WriteLine("\n");
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("******************************  Welcome to the Product Analytics  ****************");
            Console.WriteLine("**********************************************************************************");

           
            //show top the highest sold product 
            List<Product> topThreeProduct = UserDL.getTopThreeSoldProduct();
            if (topThreeProduct == null)
            {
                Console.WriteLine("Due to the less data We can't commpare");
            }
            else
            {
                barChar();
                for (int i = 0; i < topThreeProduct.Count; i++)
                {
                    if (i == 3)
                    {
                        break;
                    }
                    if(i==0)
                    {
                        Console.SetCursorPosition(5, 13);
                        Console.Write(topThreeProduct[i].getProductName());
                        Console.SetCursorPosition(17, 13);
                        Console.Write(topThreeProduct[i+1].getProductName());
                        Console.SetCursorPosition(28, 13);
                        Console.WriteLine(topThreeProduct[i+2].getProductName());
                    }
                 


                }
                //show top product in tabular form
                Console.WriteLine("Top Sold Products:");
                Console.WriteLine("---------------------------------------------------------------------");
                Console.WriteLine("|   Index   |   Product Name   |   Price   |   Quantity   | Category |");
                Console.WriteLine("---------------------------------------------------------------------");

                for (int i=0;i<topThreeProduct.Count;i++)
                {
                    if(i==3)
                    {
                        break;
                    }
                    else
                    {
                        if (i != 3)
                        {
                            Product item = topThreeProduct[i];
                            Console.WriteLine($"|   {i,-8} |   {item.getProductName(),-15} |   ${item.getProductPrice(),-7} |   {item.getproductQuantity(),-10} | {item.catagory(),-8} |");
                        }
                    }
                }
                    Console.WriteLine("-----------------------------------------------------------------");
            }



            Console.ReadKey();
        }

        public static void barChar()
        {
            char box = '\u2588';

            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine("|" + new string(' ', 10));
            }

            Console.WriteLine(new string('-', 30));

            for (int i = 0; i < 5; i++)
            {
                Console.SetCursorPosition(5, 11 - i);
                Console.Write(box);
            }

            for (int i = 0; i < 3; i++)
            {
                Console.SetCursorPosition(16, 11 - i);
                Console.Write(box);
            }

            for (int i = 0; i < 2; i++)
            {
                Console.SetCursorPosition(27, 11 - i);
                Console.Write(box);
            }
            Console.WriteLine();
        }



        public static void productDetail()
        {
            
            Console.WriteLine("************************************************************************");
            Console.WriteLine("*                              Product Detail                          *");
            Console.WriteLine("************************************************************************");

            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("|   Index   |   Product Name   |   Price   |   Quantity   |   Stock  |");
            Console.WriteLine("---------------------------------------------------------------------");

            for(int i = 0; i < AdminDL.productList.Count;i++)
            {
                Product item = AdminDL.productList[i];
                string productStock = item.getproductQuantity() > 0 ? "In Stock" : "Out of Stock";
                Console.ForegroundColor = item.getproductQuantity() > 0 ? ConsoleColor.Green : ConsoleColor.Red;
                Console.WriteLine($"|   {i,-8} |   {item.getProductName(),-15} |   ${item.getProductPrice(),-7} {item.getproductQuantity(),-10} | {productStock,-8} |");

            }
            Console.Write("Do you want to add more product(y/n)");
            char addMoreProduct = char.Parse(Console.ReadLine());
            if(addMoreProduct=='y')
            {
                Console.Write("Enter Index of the product you want to update");
                int index = int.Parse(Console.ReadLine());
                Product updateTheProduct = ProductDL.getProdcutByIndex(index);
                if(updateTheProduct!=null)
                {
                Console.Write("Enter the Quantity you want to update");
                int updatedQuantity = int.Parse(Console.ReadLine());
                if(AdminDL.productList[index].setProductQunatity(updatedQuantity))
                    {
                    //update the product file as well 
                    ProductDL.storeProductDataIntoTheFile();
                        Console.Write("product updated successfully ");
                    }

                }
                else
                {
                    Console.WriteLine("Enter the correct index");
                }

            }
            Console.ReadKey();
        }


        public static void changeProfileSetting()
        {
            Console.Write("Enter your name ");
            string name = Console.ReadLine();
            Console.Write("Enter your password ");
            string password = Console.ReadLine();
            userLogin user = new userLogin(name, password, "admin");
            if (SingUpDL.userExist(user))
            {
                UserDL.udpateAdmin(user);
                SingUpDL.storeLoginDataIntoTheFile();//udpate the file
            }
            else
            {
                Console.Write("Enter your correct crendentials");
            }
        }

        public static void deeteAdmin()
        {
            Console.Write("Enter your name ");
            string name = Console.ReadLine();
            Console.Write("Enter your password ");
            string password = Console.ReadLine();
            userLogin user = new userLogin(name, password, "admin");
            if (SingUpDL.userExist(user))
            {
                UserDL.deleteUserAccount(user);
                SingUpDL.storeLoginDataIntoTheFile();//udpate the file
            }
            else
            {
                Console.Write("Enter your correct crendentials");
            }
        }
    }
}


 
