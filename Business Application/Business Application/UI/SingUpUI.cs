using Business_Application.BL;
using Business_Application.DL;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Application.UI
{
    public class SingUpUI
    {
        public static SingUp getUserSingUpData()
        {
            Console.Write("Enter your name ");
            string name = Console.ReadLine();
            Console.Write("Enter your password ");
            string password = Console.ReadLine();
            Console.Write("Enter your role (admin/user) ");
            string role = Console.ReadLine();
             
            if(role=="admin")
            {
               
                SingUp admin = new SingUp(name, password,role);
                if (SingUpDL.isAdminAlreadyResitered(admin))
                {
                    Console.WriteLine("Admin alreaedy regsitered..");
                    return null;
                }

                return admin;
            }

            SingUp user = new SingUp(name, password);
            return user;

        }

        public static void addUserIntoLsit(SingUp user)
        {
            SingUpDL.adddUSerIntoUserLsit(user);
        }
    }
}
