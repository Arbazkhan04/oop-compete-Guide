using Deparmental_Store.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deparmental_Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MUserUI.loadLoginDataIntoArray();
            userCredentials();
        }

        static void userCredentials()
        {
            MUserUI.loginScreenMenu();
            int opt=MUserUI.getInput();
            if (opt == 1)
            {
                Console.Clear();
                MUserUI.singUp();
            }
            else if (opt == 2)
            {
                Console.Clear();
                MUserUI.singIn();
            }


        }

       
    }
}
