using coffeApp.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coffeApp.DL
{
    public class OrderCrud
    {
         static List<string> order = new List<string>();

        public static void addOrder(string name)
        {
            if (isOrderExist(name))
            {
                order.Add(name);
            }
        }
        public static bool isOrderExist(string name)
        {
            foreach (MenuItem menulist in coffeeShopCrud.menuitem)
            {
                if (name == menulist.name)
                {
                    return true;
                }
            }
            return false;
        }
        public static string fulFillOrder()
        {
            string firstOrder = order[0];
            order.RemoveAt(0);
            return firstOrder;
        }
        //this functionality also be useable as is order fulfilledx
        public static bool orderList()
        {
            if(order.Count==0)
            {
                return true;
            }
            return false;
        }
        //list of roder will be shown in UI


        public static int totalPayableAmount()
        {
            int totalPayableAmount = 0;
           if(orderList())
            {
                foreach(MenuItem menu in coffeeShopCrud.menuitem)
                {
                    foreach(string name in order)
                    {
                        if(name==menu.name)
                        {
                            totalPayableAmount += menu.price;
                        }
                    }
                }
            }
            else
            {
                return  totalPayableAmount;
            }
            return totalPayableAmount;
        }

    }
}
