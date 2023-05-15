using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Deparmental_Store.BL
{
    public class Product
    {
        public String productNAme;
        public  string productCataGroy;
        public int productPrice;
        public int availablityQuantity;
        public int minimumStockThreshold;

        public Product(string productNAme, string productCataGroy, int productPrice, int availablityQuantity, int minimumStockThreshold)
        {
            this.productNAme = productNAme;
            this.productCataGroy = productCataGroy;
            this.productPrice = productPrice;
            this.availablityQuantity = availablityQuantity;
            this.minimumStockThreshold = minimumStockThreshold;
        }
    }
}
