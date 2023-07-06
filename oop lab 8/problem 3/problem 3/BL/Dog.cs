using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace problem_3.BL
{
    public class Dog:Cat
    {
        public Dog(string name) : base(name)
        {
            this.name = name;
        }

        public override void greets()
        {
            Console.Write("Meow");
        }

        public override string ToString()
        {
            string info = "name is " + name;
            return info;
        }
    }
}
