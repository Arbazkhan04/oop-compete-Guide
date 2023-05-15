using Deparmental_Store.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deparmental_Store.DL
{
    internal class productCrudcs
    {
        public static List<Product> product= new List<Product>();

        public static void addProduct(Product productObj)
        {
            product.Add(productObj);
        }
        public static List<Product> getAllProductt()
        {
            return product;
        }
    }
}
