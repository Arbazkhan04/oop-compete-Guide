using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class clockType
    {
        public clockType()
        {
            hour = 0;
            min = 0;
            sec = 0;
        }
        public clockType(int h)
        {
            hour = h;
        }
        public clockType(int h,int s)
        {
            hour = h;
            sec = s;
        }
        public clockType(int h,int m,int s)
        {
            hour= h;
            min = m;
            sec = s;
        }
        public void printTime()
        {
            Console.WriteLine("hour" + hour + "minute"+min 
                +"second " + sec);
        }
        public void incrementInHour()
        {
            hour++;
        }
        public void incrementInMinute()
        {
            min++;
        }
        public void incrementInSecond()
        {
            sec++;
        }
        public bool isEqual(int h,int m,int s)
        {
            if(hour==h && min==m&& sec==s)
            {
                return true;
            }
            return false;
        }
        public bool isEqual(clockType temp)
        {
            if(hour==temp.hour && min==temp.min && sec==temp.sec)
            {
                return true;
            }
            return false;
        }
        public void elapsedTime()
        {
            int 
        }
        public void remainingTime()
        {
            int ReminagHour = 24 - hour;
            Console.WriteLine("Remaining hour " + ReminagHour + "min " + min + "second " + sec);
        }
        public int hour;
        public int min;
        public int sec;
      
    }
}
