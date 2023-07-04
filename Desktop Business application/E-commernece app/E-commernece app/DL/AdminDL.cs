using Business_Application.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Application.DL
{
    public class AdminDL
    {
        public static List<Product> productList = new List<Product>();

        public static List<Product> getAllProduct()

        {
            return productList;
        }
    }
}
