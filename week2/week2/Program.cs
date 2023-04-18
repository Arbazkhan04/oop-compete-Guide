using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace week2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // task1();
            //task2();
            navigationFor1();

        }

        static char menu()
        {
            Console.WriteLine("press1 for add students ");
            Console.WriteLine("press2 for view students ");
            Console.WriteLine("press3 for top stuendts ");
            char option = char.Parse(Console.ReadLine());
            return option;
        }
        static void navigationFor1()
        {
            students[] s = new students[10];
            char option;
            int count = 0;
            do
            {
                option = menu();
                if (option == '1')
                {
                     s[count]=addStudents();
                    count++;
                }
                else if (option == '2')
                {
                    viewStudents();
                }
                else if (option == '3')
                {
                    topStudents();
                }
            } while (option != '4');
            Console.WriteLine("press enter to exit ");
            Console.ReadKey();
               
        }

        static void topStudents()
        {
            Console.WriteLine("Top students work ");
        }
        static students addStudents()
        {
            students s1 = new students();
            Cosnole.


            return;
        }
        static void viewStudents()
        {
            Console.WriteLine("view student works ");
        }
        static void task1()

        {
            student s1 = new student();
            Console.Write("Enter your name ");
            s1.name = Console.ReadLine();
            Console.Write("Enter your marks ");
            s1.roll_no = int.Parse(Console.ReadLine());
            Console.Write("Enter your Cgpa ");
            s1.cgpa = int.Parse(Console.ReadLine());
            Console.WriteLine("your name {0} and marks {1} and your cgpa {2}", s1.name, s1.roll_no, s1.cgpa);
            Console.ReadKey();
        }
        static void task2()
        {
            student s1 = new student();
            Console.Write("Enter your name ");
            s1.name = Console.ReadLine();
            Console.Write("Enter your marks ");
            s1.roll_no = int.Parse(Console.ReadLine());
            Console.Write("Enter your Cgpa ");
            s1.cgpa = int.Parse(Console.ReadLine());
            student s2 = new student();
            Console.Write("Enter your name ");
            s2.name = Console.ReadLine();
            Console.Write("Enter your marks ");
            s2.roll_no = int.Parse(Console.ReadLine());
            Console.Write("Enter your Cgpa ");
            s2.cgpa = int.Parse(Console.ReadLine());
            Console.WriteLine("your name {0} and marks {1} and your cgpa {2}", s2.name, s2.roll_no, s2.cgpa);
            Console.ReadKey();
        }
    }
}
