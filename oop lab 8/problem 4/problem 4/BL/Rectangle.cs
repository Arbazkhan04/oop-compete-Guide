using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem_4.BL
{
    public class Rectangle:Shapes
    {
        public int height;
        public Rectangle(int h,int w):base(w)
        {
            this.height = h;
            this.lenght = w;

        }

        public override float Area()
        {
            float area = this.height * this.lenght;
            return area;
        }

        public override string type()
        {
            return "rectangle";
        }
    }
}
