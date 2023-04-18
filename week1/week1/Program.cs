using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace week1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //task1();
            //task2();
            //task3();
            //task4();
            //task7();
            //task89();
            //task10();
            //task11();
            //task12();
            //task13();
            //task15();
            //task16();
            getInputs();


        }
        static void task1()
        {
            Console.Write("hello world");
            Console.Write("hello world");
            Console.ReadKey();
        }
        static void task2()
        {
            Console.WriteLine("Hello wrold");
            Console.Write("hello world");
            Console.ReadKey();
        }
        static void task3()
        {
            int a = 3;
            Console.WriteLine("Value is ");
            Console.Write(a);
            Console.ReadKey();
        }
        static void task4()
        {
            String intro = "My name is khan";
            Console.WriteLine("Stirng ");
            Console.Write(intro);
            Console.WriteLine();
            Console.ReadKey();
        }
        static void task5()
        {
            char a = 'A';
            Console.WriteLine("Character ");
            Console.Write(a);
            Console.ReadKey();
        }
        static void task6()
        {
            float a = 2.6F;
            Console.WriteLine("Float ");
            Console.Write(a);
            Console.ReadKey();
        }
        static void task7()
        {
            String str;
            str=Console.ReadLine();
            Console.WriteLine("You have inputted");
            Console.Write(str);
            Console.ReadKey();

        }
        static void task89()
        {
            String str;
            Console.WriteLine("Enter a numer ");
            str = Console.ReadLine();
            int num1 = int.Parse(str);
            Console.WriteLine(num1);
            //next task
            String str2;
            Console.WriteLine("Enter a floating point number ");
            str2 = Console.ReadLine();
            float num2 = float.Parse(str2);
            Console.WriteLine(num2);
            Console.ReadKey();

        }

        static void task10()
        {
            String lenght,width;
            int Area;
            Console.WriteLine("Enter the lenght of reactanule");
            lenght = Console.ReadLine();
            int Olenght = int.Parse(lenght);
            Console.WriteLine("Enter the widht of rectanule");
            width = Console.ReadLine();
            int OWidth = int.Parse(width);
             Area = Olenght * OWidth;
            Console.Write("Area of recanle"+ Area);
            Console.ReadKey();

        }
        static void task11()
        {
            String str;
            Console.WriteLine("Enter a number");
            str = Console.ReadLine();
            int num = int.Parse(str);
            
            if(num<50)
            {
                Console.Write("you are failed");
            }
            else
            {
                Console.Write("you are passed");
            }
        }
        static void task12()
        {
            for(int i=0;i<5;i++)
            {
                Console.Write("Welcome jack");
            }
        }
        static void task13()
        {
            string str;
            int sum = 0;
            str = Console.ReadLine();
            int num2 = int.Parse(str);
            while(num2!=-1)
            {
                sum += num2;
                Console.WriteLine("Enter a more number");
                str = Console.ReadLine();
                num2 = int.Parse(str);

            }
            Console.WriteLine("sum is "+sum);
            Console.ReadKey();
        }
        static void task14()
        {
            
            int num,sum=0;
            num = int.Parse(Console.ReadLine());
            do
            {
                sum = sum + num;
                num = int.Parse(Console.ReadLine());
            }
            while (num != -1);
            sum = sum + 1;
            Console.WriteLine(sum);

             
            

        }

        static void task15()
        {
            int[] myArr = new int[3];
            int largest = -10000;
            for(int i=0;i<3;i++)
            {
                Console.WriteLine("Enter a numer");
                int num1 = int.Parse(Console.ReadLine());
                myArr[i] = num1;
            }
           for(int i=0;i<3;i++)
            {
                if (myArr[i]>largest)
                {
                    largest = myArr[i];
                }
            }
            Console.WriteLine("Largest is {0}", largest);
            Console.ReadKey();
        }
        static void task16()
        {
            int toy=0;
           // float recievedMoney = 10.0F;
            float totalMoney = 0;
            Console.WriteLine("Enter lily age");
            int lilyAge = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter price for washing machine");
            float washingMachinePrice = float.Parse(Console.ReadLine());
            Console.WriteLine("Ente toy price");
            int toyPrice = int.Parse(Console.ReadLine());

            for(int i=0;i< lilyAge;i++)
            {
                if(lilyAge%2==0)
                {
                    totalMoney += 10;
                }
                else
                {
                    toy++;
                }
            }
            int toySoldToys = toy * toyPrice;
            int RemtoyAmount = toySoldToys - toy;
            float totalSavedAmount = totalMoney + RemtoyAmount;
            if(totalSavedAmount< washingMachinePrice)
            {
                float remAmount = totalSavedAmount - washingMachinePrice;
                Console.WriteLine("yes {0}", remAmount);
                Console.ReadKey();
            }
            else
            {
                float remAmount = washingMachinePrice - totalSavedAmount;
                Console.WriteLine("No {0}", remAmount);
                Console.ReadKey();
            }
        }
        static void getInputs()
        {
            Console.WriteLine("Enter a first number ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a second number");
            int b = int.Parse(Console.ReadLine());
            int c=task11(a, b);
            Console.WriteLine(c);
            Console.ReadKey();



        }
        static int  task11(int a,int b)
        {
            return a + b;
        }
            
    }
}
