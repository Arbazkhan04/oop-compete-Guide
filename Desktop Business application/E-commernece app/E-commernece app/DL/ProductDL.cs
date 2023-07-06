using Business_Application.BL;
//using Business_Application.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Xml;

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
                if (pll.getProductName() == p.getProductName() && pll.getProductPrice() == p.getProductPrice() && pll.getproductQuantity() == p.getproductQuantity())
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
                if (pll.getProductName() == p.getProductName() && pll.getProductPrice() == p.getProductPrice() && pll.getproductQuantity() == p.getproductQuantity())
                {
                    Console.WriteLine("now update the product");
                  //  Product p2 = ProductUI.updateProduct();
                 /*   pll.setProductName(p2.getProductName());
                    pll.setProductPrice(p2.getProductPrice());
                    pll.setProductQunatity(p2.getproductQuantity())*/
                }
            }
        }

        public static void deleteProduct(Product p)
        {
            for (int i = AdminDL.productList.Count - 1; i >= 0; i--)
            {
                Product pll = AdminDL.productList[i];
                if (pll.getProductName() == p.getProductName() && pll.getProductPrice() == p.getProductPrice() && pll.getproductQuantity() == p.getproductQuantity())
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
            List<Product> filteredProducts = AdminDL.productList.Where(p => p.getProductName() == name).ToList();
            return filteredProducts;
        }


        public static void storeProductDataIntoTheFile()
        {
            String path = "C:\\Users\\Arbaz khan\\OneDrive\\Desktop\\oop-compete-Guide\\Desktop Business application\\E-commernece app\\E-commernece app\\bin\\Debug\\Product.txt";
            StreamWriter file = new StreamWriter(path, false);

            foreach(Product p in AdminDL.productList)
            {
            file.WriteLine(p.getProductName() + "," + p.getProductPrice() + "," + p.getproductQuantity()+","+p.catagory()+","+p.taxPerProduct());
            }

            file.Flush();
            file.Close();
        }

        public static bool laodProductDataFromFile()
        {
            String path = "C:\\Users\\Arbaz khan\\OneDrive\\Desktop\\oop-compete-Guide\\Desktop Business application\\E-commernece app\\E-commernece app\\bin\\Debug\\Product.txt";
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
                    if (pCatagory == "Mobile")
                    {
                        Mobiles mobile = new Mobiles(pName, pPrice, pQuantity);
                        
                        addProduct(mobile);//add product into file
                        
                    }
                    else if (pCatagory == "clothes")
                    {
                        Clothes cloth = new Clothes(pName, pPrice, pQuantity);
                        
                        addProduct(cloth);
                        
                    }
                }

                file.Close();
                return true;
            }
            else
            {
                Console.Write("Path not exist ");
                return false;
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

        public static void updateProductListQuantity(int index, int quantity)
        {
           int updatedQuantity = AdminDL.productList[index].getproductQuantity() -quantity;
            AdminDL.productList[index].setProductQunatity(updatedQuantity);
        }

    }
}
