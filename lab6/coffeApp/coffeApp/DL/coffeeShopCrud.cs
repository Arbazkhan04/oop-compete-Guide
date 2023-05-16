using coffeApp.BL;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace coffeApp.DL
{
    public class coffeeShopCrud
    {
        public static List<MenuItem> menuitem = new List<MenuItem>();
        public static void addMenuItem(MenuItem item)
        {
            menuitem.Add(item);
        }

        public static MenuItem viewCheapestItemInMenu()
        {
            int min = 0;
            foreach(MenuItem menuList in menuitem)
            {
              if(min<menuList.price)
                {
                    min=menuList.price;
                }
            }

            foreach (MenuItem menuList in menuitem)
            {
               if(min>0 && min==menuList.price)
                {
                    return menuList;
                }
            }

            return null;
        }

        public static List<MenuItem> viewDrinkkMenu()
        {
            List<MenuItem> menuForDrink = new List<MenuItem>();
            foreach(MenuItem menu in menuitem)
            {
                if(menu.type=="drink")
                {
                    menuForDrink.Add(menu);
                }
            }

            return menuForDrink; 
        }

        public static List<MenuItem> viewFoodMenu()
        {
            List<MenuItem> menuForFood = new List<MenuItem>();
            foreach (MenuItem menu in menuitem)
            {
                if (menu.type == "food")
                {
                    menuForFood.Add(menu);
                }
            }
            return menuForFood;

        }
     }
  }
