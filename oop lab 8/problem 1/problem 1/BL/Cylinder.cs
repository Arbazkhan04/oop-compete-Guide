using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem_1.BL
{
    public class Cylinder:Circle
    {
        public double height;

        public Cylinder()
        {
           
        }
        public Cylinder(double radius):base(radius)
        {
            this.radius = radius;   
        }

        public Cylinder(double radius,double height):base(radius)
        {
             this.radius = radius;
             this.height = height;
        }

        public Cylinder(double 
            height,double radius,string color):base(radius,color)
        {
            this.height = height;
            this.radius = radius;
            this.color = color;
        }

    }
}
