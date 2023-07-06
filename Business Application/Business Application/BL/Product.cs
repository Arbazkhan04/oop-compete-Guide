using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Application.BL
{
    public class Product
    {
        protected string productName;
        protected int  productPrice;
        protected int productQuantity;

        public Product(string productName, int productPrice, int productQuantity)
        {
            this.productName = productName;
            this.productPrice = productPrice;
            this.productQuantity = productQuantity;
        }

        public bool setProductName(string name)
        {
            if (!string.IsNullOrEmpty(name) || name != " ")
            {
                this.productName = name;
                return true;
            }
            return false;
        }

        public bool setProductQunatity(int quantity)
        {
            if (quantity>0 && quantity<200)
            {
                this.productQuantity = quantity;
                return true;
            }
            return false;
        }

        public bool setProductPrice(int productPrice)
        {
            if (productPrice>0 && productPrice<10000)
            {
                this.productPrice = productPrice;
                return true;
            }
            return false;
        }

        public string getProductName() { return productName; }
        public int getProductPrice() { return productPrice; }
        public int getproductQuantity() { return productQuantity; }


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
