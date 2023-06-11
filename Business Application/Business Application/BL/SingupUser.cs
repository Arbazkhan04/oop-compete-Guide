using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Application.BL
{
    public class SingupUser:SingUp
    {
        public string role;

        public SingupUser(string name,string password) : base(name, password)
        {
            this.name = name;
            this.password = password;
            this.role = "user";
        }
    }
}
