using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uams.BL
{
    public class Student
    {
        public string name;
        public int age;
        public double fscMarks;
        public double merit;
        public double ecatMarks;
        public List<DegreeProgram> preference;
        public List<Subject> registeredSubejct;
        public DegreeProgram regDegree;

        public Student(string name, int age, double fscMarks, double ecatMarks,List<DegreeProgram> preference)
        {
            this.name = name;
            this.age = age;
            this.fscMarks = fscMarks;
            this.ecatMarks = ecatMarks;
            this.preference = preference;

        }

        public void calcalteMerit()
        {
            this.merit = (((fscMarks / 1100) * 0.45F) + ((ecatMarks / 400) * 0.55F)) * 100;
        }
        public bool regStudentSubect(Subject s)
        {
            int stch = getCreditHours();
            if(regDegree!=null && regDegree.isSubjectExist(s) && stch+s.creditHour<=19)
            {
                return true;
            }
            return false;

        }

        public int getCreditHours()
        {
            int count = 0;
            foreach(Subject sub in registeredSubejct)
            {
                count = count + sub.creditHour;
            }
            return count;
        }
        public float calculateFee()
        {
            float fee = 0;
            if(regDegree!=null)
            {
                foreach(Subject sub in registeredSubejct)
                {
                    fee = fee + sub.subejctFee;
                }
            }
            return fee;
        }
    }
}
