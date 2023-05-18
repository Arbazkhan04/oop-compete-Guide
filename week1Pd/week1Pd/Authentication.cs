using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week1Pd
{
    public class Authentication
    {
        public String name;
        public String password;

        public Authentication(String name, String password)
        {
            this.name = name;
            this.password = password;
        }
    }

    public class items 
    {
        public string productName;
        public int productPrice;
        public int productQuantity;

        public  items(String productName, int productPrice, int productQuantity)
        {
            this.productName = productName;
            this.productPrice = productPrice;
            this.productQuantity = productQuantity;
        }
    }

}
