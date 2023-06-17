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
            SingUpDL.laodLoginDataFromFile();
            UserDL.loadPurchasedData();
            ProductDL.laodProductDataFromFile();

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
                   // SingUpDL.laodLoginDataFromFile(); //load data from file 
                    userLogin();
                }
                Console.Clear();
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
              // SingUpDL.laodLoginDataFromFile(); //first load data from the file into the list 
               SingUpUI.addUserIntoLsit(user);
               SingUpDL.storeLoginDataIntoTheFile();//store data into file
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
                    Console.Clear();
                    UserUI.userNavigationComp();
                }
                else if(user.role=="admin")
                {
                    Console.Clear();
                    AdminUI.adminNavigateComp();

                    //navigate toward admin
                }
            }

        }
    }
}
