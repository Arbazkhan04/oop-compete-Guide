using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Application.BL
{
    public class Mobiles:Product
    {
        public Mobiles(string pName, int pPrice, int pQuantity) : base(pName, pPrice, pQuantity)
        {
            this.productName = pName;
            this.productPrice = pPrice;
            this.productQuantity = pQuantity;
        }

        public override string catagory()
        {
            return "Mobiles";
        }

        public override double taxPerProduct()
        {
            return this.productPrice * 0.03F;
        }
    }
}
