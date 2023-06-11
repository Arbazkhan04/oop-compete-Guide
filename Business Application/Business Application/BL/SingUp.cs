using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Application.BL
{
    public class SingUp
    {
        public string name;
        public string password;
        public string role;



        public SingUp(string name, string password)//user
        {
            this.name = name;
            this.password = password;
            this.role = "user";
        }

        public SingUp(string name,string password,string role) //admin
        {
            this.name = name;
            this.password = password;
            this.role = role;
        }




    }
}
