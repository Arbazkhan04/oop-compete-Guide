using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task3.BL;

namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product p = new Product("abc", "fine", 12);
            Customer customer = new Customer("ali", "lahote", 12);
            customer.addProduct(p);
           List<Product> products= customer.getAllProdct();
            foreach(Product product in products) {
                Console.WriteLine(product.productName);
            }

            Console.WriteLine(customer.calcualteTax());

            Console.ReadKey();

        }
    }
}
