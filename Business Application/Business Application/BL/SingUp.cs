using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Application.BL
{
    public class SingUp
    {
         private string name;
         private string password;
         private string role;
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
        public bool setName(string name)
        {
            if(!string.IsNullOrEmpty(name))
            {
                this.name = name;
                return true;
            }
            
            return false;
        }
        public bool setPassword(string password)
        {
            if (!string.IsNullOrEmpty(password) || password!=" ")
            {
                this.password = password;
                return true;
            }
            return false;
        }

        public bool setRole(string role)
        {
            if(role=="admin"||role=="user")
            {
                this.role = role;
                return true;
            }
            return false;
        }

        public string getName() { return this.name;}
        public string getPassword() { return this.password; }
        public string getRole() { return this.role; }

    }
}
