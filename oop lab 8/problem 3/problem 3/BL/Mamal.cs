using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem_3.BL
{
    public class Mamal:Animal
    {
        public Mamal(string name):base(name)
        {
            this.name = name;
        }

        public override string ToString()
        {
            string info = "name is " + name;
            return info;
        }
    }
}
