using challenge1.Bl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge1.DL
{
    internal class MyLineCrud
    {
        MyLine myLine;
        public MyLineCrud(MyLine line)
        {
            this.myLine = line;
        }

        public MyPoint getBeginpoint()
        {
            return this.myLine.begin;
        }
        public void setBeginPoint(MyPoint point)
        {
            this.myLine.begin = point;  
        }
        public MyPoint getEndPoint()
        {
            return this.myLine.end;
        }
        public void setEndPoint(MyPoint point) {

            this.myLine.end = point;
        }

        public double geetLength()
        {

            int x1 = this.myLine.begin.x - this.myLine.end.x;
            int y1 = this.myLine.begin.y - this.myLine.end.y;
            double distance = Math.Sqrt(x1 * x1 + y1 * y1);
            return distance;
        }

        public double getGradient()
        {
            int x1 = this.myLine.begin.x - this.myLine.end.x;
            int y1 = this.myLine.begin.y - this.myLine.end.y;

            double greadinet = y1 / x1;
            return greadinet;

        }
    }
}
