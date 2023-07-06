using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem_4.BL
{
    public class square:Shapes
    {
        public int side;
        public square(int side,int side2):base(side2)
        {
            this.side = side;
            this.lenght = side2;
        }

        public override float Area()
        {
            int area = this.side * this.lenght;
            return area;
        }

        public override string type()
        {
            return "square";
        }
    }
}
