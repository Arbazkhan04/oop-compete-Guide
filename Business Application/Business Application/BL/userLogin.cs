using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Application.BL
{
    public class userLogin
    {
        public string name;
        public string pasword;
        public string role;

        public userLogin(string name, string pasword, string role)
        {
            this.name = name;
            this.pasword = pasword;
            this.role = role;
        }
    }
}
