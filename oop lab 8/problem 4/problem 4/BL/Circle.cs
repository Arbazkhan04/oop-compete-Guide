using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem_4.BL
{
    public class Circle:Shapes
    {
        public int radius;
        public Circle(int radius)
        {
            this.radius = radius;
        }

        public override float Area()
        {
            float area = 2 * (3.14F) * this.radius * this.radius;
            return area;
        }

        public override string type()
        {
            return "Circle";
        }
    }
}
