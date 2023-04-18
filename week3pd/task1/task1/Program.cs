using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            clockType empty_time = new clockType();
            Console.WriteLine("empty time");
            empty_time.printTime();
            //hour time
            clockType hourTime = new clockType(8);
            Console.WriteLine("hour time");
            hourTime.printTime();

            // minute time
            clockType minuteTime = new clockType(8, 9);
            Console.WriteLine("hour and minute time");
            minuteTime.printTime();

            // second time
            clockType fullTime = new clockType(8,9,10);
            Console.WriteLine("second minute and hour tuime");
            fullTime.printTime();

            fullTime.incrementInSecond();
            Console.WriteLine("incement in second ");
            fullTime.printTime();

            fullTime.incrementInMinute();
            Console.WriteLine("increment in minute");
            fullTime.printTime();

            fullTime.incrementInHour();
            Console.WriteLine("increment in hour");
            fullTime.printTime();

            //check if equal

            bool flag = fullTime.isEqual(8, 3, 3);
            Console.WriteLine("flag " + flag);

            clockType cmp = new clockType(5, 34, 2);
             flag=fullTime.isEqual(cmp);
            Console.WriteLine("flag " + flag);
            Console.Read();
        }
    }
}
