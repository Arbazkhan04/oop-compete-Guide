using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3.BL
{
    internal class Product
    {
        public String productName;
        public String productCatagory;
        public int price;
        public Product(string productName, string productCatagory, int price)
        {
            this.productName = productName;
            this.productCatagory = productCatagory;
            this.price = price;
        }
    }
}
