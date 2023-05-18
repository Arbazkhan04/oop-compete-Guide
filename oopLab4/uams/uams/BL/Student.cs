using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace uams.BL
{
    internal class Student
    {
        public String name;
        public int age;
        public int fscMarks;
        public int ecatMarks;
        public int numberOfPreferences;


        List<Student> students = new List<Student>();
        public Student(string name, int age, int fscMarks, int ecatMarks, int numberOfPreferences)
        {
            this.name = name;
            this.age = age;
            this.fscMarks = fscMarks;
            this.ecatMarks = ecatMarks;
            this.numberOfPreferences = numberOfPreferences;

        }

       public  List<Student> getAllStudnet()
        {
            return students;
        }
        public  void addStudnet(Student studnet)
        {
            students.Add(studnet);
        }

    }
}
