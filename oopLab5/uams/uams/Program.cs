using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using uams.BL;

namespace uams
{
    internal class Program
    {
        static List<Student> studentList = new List<Student>();
        static List<DegreeProgram> programList = new List<DegreeProgram>();
        static void Main(string[] args)
        {
            int option;
            do
            {
                option = menu();
                clearScreen();
                if (option == 1)
                {
                    if (programList.Count > 0)
                    {
                        Student s = takeInputForStudent();
                        addInotStudentList(s);
                    }
                }
                else if (option == 2)
                {
                    DegreeProgram d = takeInputForDegree();
                    addIntoDegreeList(d);

                }
                else if (option == 3)
                {
                    List<Student> sortedStudent = new List<Student>();
                    sortedStudent = sortSudentByMerit();
                    giveAdmision(sortedStudent);
                    printStudnet();


                }
                else if (option == 4)
                {
                    viewRegisteredStudents();
                }
                else if (option == 5)
                {
                    string degName;
                    Console.WriteLine("Enter degree name ");
                    degName = Console.ReadLine();
                    viewStudentInDegree(degName);
                }

                else if (option == 6)
                {
                    Console.WriteLine("Entert studnet name");
                    string anme = Console.ReadLine();
                    Student s = studentPresent(anme);
                    if (s != null)
                    {
                        viewSubject(s);
                        registerSubejcts(s);
                    }
                }
                else if (option == 7)
                {
                    calculateFFeeFroAll();
                }
                clearScreen();


            }
            while (option != 8);
            Console.ReadKey();
        }
        static Student studentPresent(string name)
        {
            foreach(Student s in studentList)
            {
                if(name==s.name && s.regDegree != null)
                {
                    return s;
                }
            }
            return null;
        }

        static void calculateFFeeFroAll()
        {
            foreach(Student  s in studentList)
            {
                if(s.regDegree != null) 
                {
                    Console.WriteLine(s.name + "has" + s.calculateFee() + "fee");
                }
            }
        }

        static void registerSubejcts(Student s)
        {
            Console.WriteLine("Enter how many subect you want to enter ");

            int count = int.Parse(Console.ReadLine());
            for(int i=0;i<count;i++)
            {
                Console.WriteLine("Enter subect code ");
                string code = Console.ReadLine();
                bool flag = false;
                foreach(Subject sub in s.regDegree.subject)
                {
                    if(code==sub.code && !(s.registeredSubejct.Contains(sub)))
                        {
                         s.regStudentSubect(sub);
                        flag = true;
                        break;
                        }
                }
                if (!flag)
                {
                    Console.WriteLine("Enter valid courser");
                    i--;
                }

            }

        }
        static List<Student> sortSudentByMerit()
        {
            List<Student> sortedStudnetList = new List<Student>();
            foreach (Student sub in studentList)
            {
                sub.calcalteMerit();
            }
            sortedStudnetList = studentList.OrderByDescending(o => o.merit).ToList();
            return sortedStudnetList;
        }

        static void giveAdmision(List<Student> sortedStudnetList)
        {
            foreach(Student s in sortedStudnetList)
            {
                foreach(DegreeProgram d in s.preference)
                {
                    if(d.seat>0 && s.regDegree == null)
                    {
                        s.regDegree = d;
                        d.seat--;
                        break;
                    }
                }
            }
          


        }

        static void printStudnet()
        {
            foreach (Student s in studentList)
            {
                if (s.regDegree != null)
                {
                    Console.WriteLine(s.name + "got addmission in" + s.regDegree.degreeProgam);
                }
                else
                {
                    Console.WriteLine(s.name + "did not get addmission ");
                }
            }
        }
        static void clearScreen()
        {
            Console.WriteLine("Press any key to continue.. ");
            Console.ReadKey();
            Console.Clear();
        }

        static void viewStudentInDegree(string degName)
        {
            Console.WriteLine("Name\tFsc\tEcat\tAge");
            foreach (Student s in studentList)
            {
                if (s.regDegree != null)
                {
                    if (degName == s.regDegree.degreeProgam)
                    {
                        Console.WriteLine(s.name + "\t" + s.fscMarks + "\t" + s.ecatMarks + "\t" + s.age);
                    }
                }
            }
        }

        static void viewRegisteredStudents()
        {
            Console.WriteLine("Name\tFsc\tEcat\tAge");
            foreach(Student  s in studentList)
            {
                if (s.regDegree != null)
                {
                    Console.WriteLine(s.name + "\t" + s.fscMarks + "\t" + s.ecatMarks + "\t" + s.age);
                }
            }
        }

        static void addIntoDegreeList(DegreeProgram d)
        {
            programList.Add(d);
        }

        static DegreeProgram takeInputForDegree()
        {
            string degreeName;
            float degreeDuration;
            int seats;
            Console.WriteLine("Enter degreee name ");
            degreeName = Console.ReadLine();
            Console.WriteLine("Enter Degree Duration ");
            degreeDuration = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter seats for degree ");
            seats = int.Parse(Console.ReadLine());
            DegreeProgram degPro = new DegreeProgram(degreeName, degreeDuration, seats);
            Console.WriteLine("how many subject you want to enter ");
            int count = int.Parse(Console.ReadLine());
            for(int i = 0; i < count; i++)
            {
                degPro.addSubject(takeInputForSubject());

            }
            return degPro;
        }

        static Subject takeInputForSubject()
        {
            string code ;
            string  type;
            int creditHour;
            int subjectFee;
            Console.WriteLine("Enter subejct code ");
            code  = Console.ReadLine();
            Console.WriteLine("Enter Suboject type ");
            type = Console.ReadLine();
            Console.WriteLine("Enter credit hour ");
            creditHour = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter subject fee ");
            subjectFee = int.Parse(Console.ReadLine());

            Subject sub = new Subject(code, type, creditHour, subjectFee);

            return sub;

        }

        static void addInotStudentList(Student s)
        {
            studentList.Add(s);
   
        }

        static Student takeInputForStudent()
        {
            string name;
            int age;
            double fscMArks;
            double ecatMarks;

            List<DegreeProgram> preference = new List<DegreeProgram>();
            Console.WriteLine("Enter the name of student ");
            name = Console.ReadLine();
            Console.WriteLine("Enter student age ");
             age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter fsc amrks");
            fscMArks = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter ecat marks");
            ecatMarks = int.Parse(Console.ReadLine());
            Console.WriteLine("Abailable degree progam ");

            viewDegreePrpgram();
            Console.WriteLine("Enter how many perference to enter ");
            int count = int.Parse(Console.ReadLine());
            for(int i=0;i<count;i++)
            {
                string degName = Console.ReadLine();
                bool flag = false;
                foreach(DegreeProgram dg in programList)
                {
                    if(degName==dg.degreeProgam && !(preference.Contains(dg)))
                        {
                        preference.Add(dg);
                        flag = true;
                        }
                }
                if (flag == false)
                {
                    Console.WriteLine("Entert valid degree name ");
                    i--;
                }

            }
            Student s = new Student(name, age, fscMArks, ecatMarks, preference);
            return s;

        }

        static void viewDegreePrpgram()
        {
            foreach(DegreeProgram dp in programList)
            {
                Console.WriteLine(dp.degreeProgam);
            }
        }

        static void header()
        {
            Console.WriteLine("************************************");
            Console.WriteLine("                UAMS                ");

            Console.WriteLine("************************************");
        }

        static void viewSubject(Student s)
        {
            if(s.regDegree!=null)
            {
                Console.WriteLine("sub code \t sub type");
                foreach(Subject sub in s.regDegree.subject)
                {
                    Console.WriteLine(sub.code + "\t\t" + sub.type);
                }
            }
        }

        static int menu()
        {
            header();
            int opt;
            Console.WriteLine("1-add student ");
            Console.WriteLine("2-add degree program ");
            Console.WriteLine("3-generage merit ");
            Console.WriteLine("4-view regestered student ");
            Console.WriteLine("5-view student fo a specific program");
            Console.WriteLine("6-Registered subject for a specfic stuendt  ");
            Console.WriteLine("7- calculate fees for all regsitered student");
            Console.WriteLine("8-Exit");
            Console.WriteLine("Enter option ");
            opt = int.Parse(Console.ReadLine());
            return opt;
            
        }
    }
}
