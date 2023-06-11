using Business_Application.BL;
using Business_Application.DL;
using Business_Application.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Application
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MainScreen.eCommerenceTitle();
            int opt=MainScreen.displaySinupAndSinginMenu();
            while(opt!=3)
            {
                if(opt==1)
                {
                    singupCredentials();
                }
                else if(opt==2)
                {
                    //loign 
                    userLogin();
                }

                MainScreen.eCommerenceTitle();
                opt = MainScreen.displaySinupAndSinginMenu();
            }
            Console.ReadLine();
        }
        static void singupCredentials()
        {
            
            SingUp user = SingUpUI.getUserSingUpData();
            if(user!=null)
            {
              SingUpUI.addUserIntoLsit(user);
            }
          
        }

        static void userLogin()
        {
            userLogin user = userLoginUI.getUserLoginData();
            if(SingUpDL.userExist(user))
            {
                if(user.role=="user")
                {
                    // navigate toward user;
                    UserUI.userNavigationComp();
                }
                else if(user.role=="admin")
                {
                   AdminUI.adminNavigateComp();
                    //navigate toward admin
                }
            }

        }
    }
}
