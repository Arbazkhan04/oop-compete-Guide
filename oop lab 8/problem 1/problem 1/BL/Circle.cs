using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem_1.BL
{
    public class Circle
    {
        protected double radius;
        protected string color;

        public Circle()
        {
        }

        public Circle(double radius, string color)
        {
            this.radius = radius;
            this.color = color;
        }
        public Circle(double radius)
        {
            this.radius = radius;
        }
    }

     


}
