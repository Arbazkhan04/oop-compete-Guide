using challenge1.Bl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge1.DL
{
    public class MyPointCrud
    {
        public MyPoint mypoint;

        public MyPointCrud(MyPoint p)
        {
            this.mypoint = p;
        }
        public int getX()
        {
            return mypoint.x;
        }

        public int getY()
        {
            return mypoint.y;
        
        }

        public void setX(int x)
        {
            this.mypoint.x = x;
        }
    
        public void setY(int y)
        {
            this.mypoint.y = y;
        }
        public void setXY(int x,int y)
        {
            this.mypoint.x = x;
            this.mypoint.y = y;

        }

        public double distanceWithCords(int x,int y)
        {
            int x1 = this.mypoint.x - x;
            int y1 = this.mypoint.y - y;
            double distance = Math.Sqrt(x1 * x1 + y1 * y1);
            return distance;
        }

        public double distanceWithObject(MyPoint anotherObject)
        {
            int x1 = this.mypoint.x - anotherObject.x;
            int y1 = this.mypoint.y - anotherObject.y;
            double distance = Math.Sqrt(x1 * x1 + y1 * y1);
            return distance;
        }

        public double distanceFromZero()
        {
            int x1 = this.mypoint.x - 0;
            int y1 = this.mypoint.y -0;
            double distance = Math.Sqrt(x1 * x1 + y1 * y1);
            return distance;
        }
    }
}
