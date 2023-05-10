using challenge1.Bl;
using challenge1.DL;
using challenge1.UIL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge1
{
    internal class Program
    {
        static MyPoint begin = new MyPoint(10, 2);
        static  MyPoint end = new MyPoint(1, 22);
        static MyLine line = new MyLine(begin, end);
        static MyLineCrud crud = new MyLineCrud(line);


        static void Main(string[] args)
        {
            myLineUi.getMenu();
            int option = myLineUi.getoption();
            while (option != 10)
            {
                if (option == 1)
                {
                    makeLine();
                }
                else if(option==2)
                {
                    updateBeginPoint();
                }
                else if (option == 3)

                {
                    updateTheEndPoint();
                }
                else if (option == 4)
                {
                    showBeginPoint();
                }
                else if (option == 6)
                {
                    getLenght();
                }
                Console.Clear();
                myLineUi.getMenu();
                option = myLineUi.getoption();
            }
        }

        static void makeLine()
        {
            Console.WriteLine("Successfully created a line ");
        }

        static void updateBeginPoint()
        {
            Console.WriteLine("Enter point for x ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Entet poit for y");
            int y = int.Parse(Console.ReadLine());
            MyPoint p = new MyPoint(x, y);
            crud.setBeginPoint(p);
            Console.WriteLine("Successfully updated a line ");
        }
        static void updateTheEndPoint()
        {
            Console.WriteLine("Enter point for x ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Entet poit for y");
            int y = int.Parse(Console.ReadLine());
            MyPoint p = new MyPoint(x, y);
            crud.setEndPoint(p);
            Console.WriteLine("Successfully updated a line ");
        }
        static void showBeginPoint()
        {
          MyPoint p=crud.getBeginpoint();
            Console.WriteLine(p.x + " " + p.y);
            Console.ReadKey();
        }

        static void getLenght()
        {
           double length= crud.geetLength();
            Console.WriteLine(length);
        }
    }
}
