using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem_2.BL
{
    public class Person
    {
        protected string name;
        protected string address;

        public Person(string name, string address)
        {
            this.name = name;
            this.address = address;
        }

        public string getName()
        {
            return name;
        }

        public string getAddress()
        {
            return address;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public virtual string toString()
        {
            string tInfo = "Name is " + this.name + " and your address " + this.address;
            return tInfo;
        }
    }
}
