using Business_Application.BL;
using System;
using System.Collections.Generic;
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
    }
}
