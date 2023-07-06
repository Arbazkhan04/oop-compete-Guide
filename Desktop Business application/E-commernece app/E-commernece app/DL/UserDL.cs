using Business_Application.BL;
//using Business_Application.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Application.DL
{
    public class UserDL
    {
        public static List<Product> userPurchasedProductList= new List<Product>();

       public static void addPurchasedProduct(Product p)
        {
            // here is error load this data into the storepruchased data inot the file 
            if(!IsPurchasedProductEist(p))
            {
            userPurchasedProductList.Add(p);
            }
            else
            {
                for (int i = 0; i < userPurchasedProductList.Count; i++)
                {
                    if (userPurchasedProductList[i].getProductName() == p.getProductName())
                    {
                       int QuantityIncrement = userPurchasedProductList[i].getproductQuantity()+p.getproductQuantity();
                        userPurchasedProductList[i].setProductQunatity(QuantityIncrement);
                       
                    }
                }
            }
        }

        public static bool IsPurchasedProductEist(Product p)
        {
            for (int i = 0; i < userPurchasedProductList.Count; i++)
            {
                if (userPurchasedProductList[i].getProductName() == p.getProductName())
                {
                    return true;
                }
            }
            return false;
        }
        public static List<Product>? getTopThreeSoldProduct() // here the ? means i can return null as well to prevent the erro message possibly return nulll value;
        {
            List<Product> product;
            product = userPurchasedProductList.OrderByDescending(p => p.getproductQuantity()).ToList();
            return product.Count<3 ? null:product;

        }
        public static void storePurchasedProductIntoTheFile()
        {
            String path = "purchasedProduct.txt";
            StreamWriter file = new StreamWriter(path, false);
             foreach(Product p in userPurchasedProductList)
            {
             file.WriteLine(p.getProductName() + "," + p.getProductPrice() + "," + p.getproductQuantity() + "," + p.catagory() + "," + p.taxPerProduct());
            }
            
            file.Flush();

            file.Close();
        }

        public static void loadPurchasedData()
        {
            string path = "purchasedProduct.txt";
            if (File.Exists(path))
            {
                StreamReader file = new StreamReader(path);
                string record; //it can hold null value;
                while ((record = file.ReadLine()) != null)
                {

                    string pName = ProductDL.parseData(record, 1);
                    int pPrice = int.Parse(ProductDL.parseData(record, 2));
                    int pQuantity = int.Parse(ProductDL.parseData(record, 3));
                    string pCategory = ProductDL.parseData(record, 4);

                    if (pCategory == "Mobile")
                    {
                        Mobiles mobile = new Mobiles(pName, pPrice, pQuantity);
                        addPurchasedProduct(mobile);
                    }
                    else if (pCategory == "clothes")
                    {
                        Clothes cloth = new Clothes(pName, pPrice, pQuantity);
                        addPurchasedProduct(cloth);
                    }
                }
                file.Close();
            }
            else
            {
                Console.Write("Path does not exist.");
            }


        }


        public static Product? getTrendingProduct(int index)
        {

            return index > 3 ? null : userPurchasedProductList[index]; 
        }

        public static void updateUser(userLogin user)
        {
            foreach (SingUp u in SingUpDL.userList)
            {
                if (user.name==u.getName() && user.pasword==u.getPassword() && user.role==u.getRole())
                {
                    Console.WriteLine("now update your crendentials");
                   // SingUp updatedUser = SingUpUI.getUserSingUpData();
                 /*   if(updatedUser!=null)
                    {
                        u.setName(updatedUser.getName());
                        u.setPassword(updatedUser.getPassword());
                        u.setRole(user.role);
                    }
                   else
                    {
                        Console.WriteLine("updation failed");
                    }
                 */
                }
            }
        }

        public static void udpateAdmin(userLogin user)
        {
            foreach (SingUp u in SingUpDL.userList)
            {
                if (user.name == u.getName() && user.pasword == u.getPassword() && user.role == u.getRole())
                {
                    Console.WriteLine("now update your crendentials");
                  //  userLogin updatedUser = userLoginUI.getDataForAdminUpdateCrendentials();
                   /* if(updatedUser!=null)
                    {
                        u.setName(updatedUser.name);
                        u.setPassword(updatedUser.pasword);
                        u.setRole(user.role);
                    }
                   else
                    {
                        Console.Write("udpation fialed ");
                    }*/
                }
            }
        }

        public static void deleteUserAccount(userLogin u)
        {
            for (int i = SingUpDL.userList.Count - 1; i >= 0; i--)
            {
                SingUp user = SingUpDL.userList[i];
                if (user.getName()==u.name && user.getPassword()==u.pasword && user.getRole()==u.role)
                {
                    SingUpDL.userList.RemoveAt(i);
                }
            }
        }
    }
}
