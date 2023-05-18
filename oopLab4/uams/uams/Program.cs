using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uams.BL;

namespace uams
{
    internal class Program
    {
        static void Main(string[] args)
        {
            menu();
            navigationScreen();

        }

        static void menu()
        {
            Console.WriteLine("1-Add Student ");
            Console.WriteLine("2-Add Degree Program ");
            Console.WriteLine("3-Generate Merit ");
            Console.WriteLine("4-View Regesteried Students ");
            Console.WriteLine("5-View Student for specfic program ");
            Console.WriteLine("6-regestered Subecjt for specific students ");
            Console.WriteLine("7-Calculate fees for all Register student ");
            Console.WriteLine("8-Exit");
        }
        static int getInput()
        {
            Console.Write("Enter option ");
            int opt = int.Parse(Console.ReadLine());
            return opt;
        }

        static void navigationScreen()
        {
            int opt = getInput();
            while (opt != 8)
            {
                if (opt == 1)
                {
                    addStudent();
                }
                else if (opt == 2)
                {
                    addDegreeProgram();
                }
                else if (opt == 3)
                {

                }
                else if (opt == 4)
                {
                    viewRegisteredStudent();
                }
                menu();
                opt = getInput();
            }
        }

        static  void addStudent()
        {

            Console.WriteLine("Enter name ");
            String name = Console.ReadLine();

            Console.WriteLine("Enter age ");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter fsc mars ");
            int fscMarks = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter ecat mars ");
            int ecatMarks = int.Parse(Console.ReadLine());

            Console.WriteLine("Availabe Degree program ");

            Console.WriteLine("how many perference to enter ");
            int perference = int.Parse(Console.ReadLine());

            Student s = new Student(name, age, fscMarks, ecatMarks, perference);

            s.addStudnet(s);//not effiecdt way 

            Console.ReadKey();


        }

       static void viewRegisteredStudent()
        {
          /*Console.Write("adk");
           
            /List<Student> students = Student.getAllStudnet();//problem

            foreach(Student student
                in students)
            {
                Console.Write("A");
                Console.WriteLine("Name\t\t Fsc\t\t Ecat\t\t Age");
                Console.WriteLine(student.name+"\t\t"+student.fscMarks + "\t\t" + student.ecatMarks + "\t\t" + student.age); 
            }
            Console.ReadKey();*/
        }

        static void addDegreeProgram()
        {
            Console.WriteLine("Enter Degree name ");
            String degreeName = Console.ReadLine();

            Console.WriteLine("Enter Degree duration ");
            int  degreeDuration = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Degree name ");
            int  seats =int.Parse(Console.ReadLine());

            Console.WriteLine("Enter subject code  name ");
            int subjectcode = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter subjectType ");
            String subjectType = Console.ReadLine();

            Console.WriteLine("Enter credit hour  ");
            int credithour = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter subject fee  ");
            int fee = int.Parse(Console.ReadLine());

            Subject s = new Subject(subjectcode, subjectType, credithour, fee);

            DegreeProgram dp = new DegreeProgram(degreeName, degreeDuration, seats, s);

            dp.addDegreeProgam(dp);
        }
    }
}
