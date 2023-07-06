using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem_4.BL
{
    public class Shapes
    {
        protected int lenght;

        public Shapes()
        { }

        public Shapes(int leght)
        {
            this.lenght = leght;
        }

        public virtual float Area()
        {
            return 0.0F;
        }
        public virtual string type()
        {
            return "";
        }
    }
}
