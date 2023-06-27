using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Application.BL
{
    public class UserPurchasedBl
    {
        public string productName;
        public int productPrice;
        public int productQuantity;
        public UserPurchasedBl(string productName, int productPrice, int productQuantity)
        {
            this.productName = productName;
            this.productPrice = productPrice;
            this.productQuantity = productQuantity;
        }
    }
}
