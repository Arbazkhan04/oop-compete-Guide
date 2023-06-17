using Business_Application.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Application.UI
{
    public class userLoginUI
    {
        public static  userLogin getUserLoginData()
        {
            Console.Write("Enter your name ");
            string name = Console.ReadLine();
            Console.Write("Enter your password ");
            string password = Console.ReadLine();
            Console.Write("Enter your role (admin/user) ");
            string role = Console.ReadLine();
            
              userLogin user = new userLogin(name, password, role);
                return user;
            
        }

        public static  userLogin  getDataForAdminUpdateCrendentials()
        {
            Console.Write("Enter name ");
            string username = Console.ReadLine();
            Console.Write("Enter password ");
            string password = Console.ReadLine();
            userLogin user = new userLogin(username, password, "admin");
            return user;
        }
    }
}
