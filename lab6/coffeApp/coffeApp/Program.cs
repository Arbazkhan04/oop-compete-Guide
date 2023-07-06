using coffeApp.BL;
using coffeApp.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coffeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int opt =CoffeeShopUI.menu();
            while(opt!=9)
            {
                if(opt==1)
                {
                    Console.Clear();
                    CoffeeShopUI.addMenuItem();
                }
                else if(opt==2)
                {
                    Console.Clear();
                    CoffeeShopUI.ViewCheapestItem();
                }
                else if(opt==3)
                {

                    Console.Clear();
                    List<MenuItem> menus=CoffeeShopUI.viewDringMenu();
                    foreach(MenuItem menu in menus)
                    {
                        Console.WriteLine(menu.name);
                    }
                    Console.ReadKey();
                }

                else if (opt == 4)
                {

                    Console.Clear();
                    List<MenuItem> menus = CoffeeShopUI.viewFoodMenu();
                    foreach (MenuItem menu in menus)
                    {
                        Console.WriteLine(menu.name);
                    }
                    Console.ReadKey();
                }
                else if(opt==5)
                {
                    CoffeeShopUI.addOrder();
                    Console.ReadKey();
                }
                else if(opt==6)
                {


                }
                Console.Clear();
                opt = CoffeeShopUI.menu();
            }
            Console.ReadKey();
        }
    }
}
