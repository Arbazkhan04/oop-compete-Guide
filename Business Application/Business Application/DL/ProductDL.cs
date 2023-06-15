using Business_Application.BL;
using Business_Application.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Business_Application.DL
{
    public class ProductDL
    {
        public static void addProduct(Product product)
        {
            AdminDL.productList.Add(product);
        }

        public static bool checkProductExist(Product p)
        {
            foreach (Product pll in AdminDL.productList)
            {
                if (pll.productName == p.productName && pll.productPrice == p.productPrice && pll.productQuantity == p.productQuantity)
                {
                    return true;
                }
            }
          
            return false;
        }

        public static void upDateProduct(Product p)
        {
            foreach (Product pll in AdminDL.productList)
            {
                if (pll.productName == p.productName && pll.productPrice == p.productPrice && pll.productQuantity == p.productQuantity)
                {
                    Console.WriteLine("now update the product");
                    Product p2 = ProductUI.updateProduct();
                    pll.productName = p2.productName;
                    pll.productPrice = p2.productPrice;
                    pll.productQuantity = p2.productQuantity;
                }
            }
        }

        public static void deleteProduct(Product p)
        {
            for (int i = AdminDL.productList.Count - 1; i >= 0; i--)
            {
                Product pll = AdminDL.productList[i];
                if (pll.productName == p.productName && pll.productPrice == p.productPrice && pll.productQuantity == p.productQuantity)
                {
                    AdminDL.productList.RemoveAt(i);
                }
            }
        }

        public static Product getProdcutByIndex(int index)
        {
            for(int i=0;i<AdminDL.productList.Count; i++)
            {
                if (i == index)
                {
                    return AdminDL.productList[i];
                }
            }
            return null;
        }

        public static List<Product> filterProduct(string name)
        {
            List<Product> filteredProducts = AdminDL.productList.Where(p => p.productName == name).ToList();
            return filteredProducts;
        }


        public static void storeProductDataIntoTheFile()
        {
            String path = "Product.txt";
            StreamWriter file = new StreamWriter(path, false);

            foreach(Product p in AdminDL.productList)
            {
            file.WriteLine(p.productName + "," + p.productPrice + "," + p.productQuantity+","+p.catagory()+","+p.taxPerProduct());
            }

            file.Flush();
            file.Close();
        }

        public static void laodProductDataFromFile()
        {
            String path = "Product.txt";
            if (File.Exists(path))
            {
                StreamReader file = new StreamReader(path);
                String record;
                while ((record = file.ReadLine()) != null)
                {
                    string pName = parseData(record, 1);
                    int pPrice = int.Parse(parseData(record, 2));
                    int pQuantity = int.Parse(parseData(record, 3));
                    string pCatagory = parseData(record, 4);
                  //  double pTax = double.Parse(parseData(record, 5));
                    if(pCatagory=="Mobile")
                    {
                        Mobiles mobile = new Mobiles(pName, pPrice, pQuantity);
                        addProduct(mobile);//add product into file
                    }
                    else if(pCatagory=="clothes")
                    {
                        Clothes cloth = new Clothes(pName, pPrice, pQuantity);
                        addProduct(cloth);  
                    }

                    foreach (Product p in AdminDL.productList)
                    {
                        Console.WriteLine(p.productName + "," + p.productPrice + "," + p.productQuantity + "," + p.catagory() + "," + p.taxPerProduct());
                    }
                }

                file.Close();
            }
            else
            {
                Console.Write("Path not exist ");
            }

        }

        public static String parseData(string data, int line)
        {
            int commaCount = 1;
            String item = "";
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == ',')
                {
                    commaCount++;
                }
                else if (commaCount == line)
                {
                    item += data[i];
                }
            }
            return item;
        }

    }
}
