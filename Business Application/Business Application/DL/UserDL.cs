using Business_Application.BL;
using Business_Application.UI;
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
            userPurchasedProductList.Add(p);
        }

        public static void storePurchasedProductIntoTheFile(Product p)
        {
            String path = "Purchased.txt";
            StreamWriter file = new StreamWriter(path, true);
             file.WriteLine(p.productName + "," + p.productPrice + "," + p.productQuantity + "," + p.catagory() + "," + p.taxPerProduct());
            
            file.Flush();
            file.Close();
        }

        public  static void loadPurchasedData()
        {
            String path = "Purchased.txt";
            if (File.Exists(path))
            {
                StreamReader file = new StreamReader(path);
                String record;
                while ((record = file.ReadLine()) != null)
                {
                    string pName = ProductDL.parseData(record, 1);
                    int pPrice = int.Parse(ProductDL.parseData(record, 2));
                    int pQuantity = int.Parse(ProductDL.parseData(record, 3));
                    string pCatagory = ProductDL.parseData(record, 4);
                    //  double pTax = double.Parse(parseData(record, 5));
                    if (pCatagory == "Mobile")
                    {
                        Mobiles mobile = new Mobiles(pName, pPrice, pQuantity);
                        addPurchasedProduct(mobile);//add product into file
                    }
                    else if (pCatagory == "clothes")
                    {
                        Clothes cloth = new Clothes(pName, pPrice, pQuantity);
                        addPurchasedProduct(cloth);
                    }
                }

                file.Close();
            }
            else
            {
                Console.Write("Path not exist ");
            }
        }

        public static Product getTrendingProduct(int index)
        {
            return index > 3 ? null : userPurchasedProductList[index]; 
        }


        public static void updateUser(userLogin user)
        {
            foreach (SingUp u in SingUpDL.userList)
            {
                if (user.name==u.name && user.pasword==u.password && user.role==u.role)
                {
                    Console.WriteLine("now update your crendentials");
                    SingUp updatedUser = SingUpUI.getUserSingUpData();
                    u.name = updatedUser.name;
                    u.password = updatedUser.password;
                    u.role = "user";
                }
            }
        }

        public static void deleteUserAccount(userLogin u)
        {
            for (int i = SingUpDL.userList.Count - 1; i >= 0; i--)
            {
                SingUp user = SingUpDL.userList[i];
                if (user.name==u.name && user.password==u.pasword && user.role==u.role)
                {
                    SingUpDL.userList.RemoveAt(i);
                }
            }
        }
    }
}
