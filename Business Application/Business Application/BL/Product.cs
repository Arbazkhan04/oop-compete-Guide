using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Application.BL
{
    public class Product
    {
        public string productName;
        public int  productPrice;
        public int productQuantity;

        public Product(string productName, int productPrice, int productQuantity)
        {
            this.productName = productName;
            this.productPrice = productPrice;
            this.productQuantity = productQuantity;
        }

        public virtual string catagory()
        {
            return  "undefined";
        }
        public virtual double taxPerProduct()
        {
            return 0;
        }
    }
}
