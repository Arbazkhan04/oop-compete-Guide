using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3.BL
{
    internal class Customer
    {
        public String customerName;
        public String customerAddress;
        public int customerContact;
        public Customer(string customerName, string customerAddress, int customerContact)
        {
            this.customerName = customerName;
            this.customerAddress = customerAddress;
            this.customerContact = customerContact;
           
        }

        List<Product> productList = new List<Product>();
        public List<Product> getAllProdct()
        {
            return productList;
        }

        public void addProduct(Product product)
        {
            productList.Add(product);
        }
        public float calcualteTax()
        {
            float tax=0.0f;
            foreach (Product product in productList)
            {
                 tax += product.price - product.price * 0.2f;
               
            }
            return tax;
        }
    }
}
