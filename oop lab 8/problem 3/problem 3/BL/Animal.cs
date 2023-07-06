using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem_3.BL
{
    public class Animal
    {
        protected string name;

        public Animal(string name) {
            this.name = name;
                }

        public virtual string ToString() 
        {
            string info = "name is " + name;
            return info;
        }


    }
}
