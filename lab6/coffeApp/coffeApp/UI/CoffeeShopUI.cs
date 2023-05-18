using coffeApp.BL;
using coffeApp.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace coffeApp.UI
{
    public class CoffeeShopUI
    {
        public static int menu()
        {
            Console.WriteLine("1-Add menu item");
            Console.WriteLine("2-view cheapest item in the menu");
            Console.WriteLine("3-view the deink's menu");
            Console.WriteLine("4-view the food's menu");
            Console.WriteLine("5-Add order");
            Console.WriteLine("6-fulfill the order");
            Console.WriteLine("7-view the order's list");
            Console.WriteLine("8-total patablee amount");
            Console.WriteLine("9-Exit");
            Console.WriteLine("Enter option ");
            int opt =int.Parse(Console.ReadLine());
            return opt;
        }

        public static void addMenuItem()
        {
            MenuItem menu = new MenuItem("banana", "food", 123);
            MenuItem menu1 = new MenuItem("banana", "food", 34);
            MenuItem menu2 = new MenuItem("banana", "drink", 53);
            MenuItem menu3 = new MenuItem("banana", "food", 1236);
            MenuItem menu4 = new MenuItem("banana", "drink", 123);
            coffeeShopCrud.addMenuItem(menu);
            coffeeShopCrud.addMenuItem(menu1);
            coffeeShopCrud.addMenuItem(menu2);
            coffeeShopCrud.addMenuItem(menu3);
            coffeeShopCrud.addMenuItem(menu4);
        }

        public static void ViewCheapestItem()
        {
          string cheapestItem= coffeeShopCrud.viewCheapestItemInMenu();
          Console.WriteLine(cheapestItem);  
        }

        public static List<MenuItem> viewDringMenu()
        {
            return coffeeShopCrud.viewDrinkkMenu();
        }

        public static List<MenuItem> viewFoodMenu()
        {
            return coffeeShopCrud.viewFoodMenu();
        }

        public static void addOrder()
        {
           if(OrderCrud.addOrder("banna"))
            {
                Console.WriteLine("order added");
            }
           else
            {
                Console.WriteLine("not added");
            }

        }
    }
}
