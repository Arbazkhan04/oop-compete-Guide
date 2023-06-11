using Business_Application.BL;
using Business_Application.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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




    }
}
