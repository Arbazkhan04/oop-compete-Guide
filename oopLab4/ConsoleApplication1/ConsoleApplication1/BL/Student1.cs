using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.BL
{
    class Student1
    {
        public String studentName;
        public String rollNo;
        public float cgpa;
        public int matricMarks;
        public int fscMarks;
        public int ecatMark;
        public int currentSemesterFee;
        public String homeTown;
        public bool isHostilite;
        public bool isAvailingSchlarship;

      
        public Student1(  String studentName,
         String rollNo,
         float cgpa,
         int matricMarks,
         int fscMarks,
         int ecatMark,
         int currentSemesterFee,
         String homeTown,
         bool isHostilite,
         bool isAvailingSchlarship)
        {
            this.studentName = studentName;
            this.rollNo = rollNo;
            this.cgpa = cgpa;
            this.matricMarks = matricMarks;
            this.fscMarks = fscMarks;
            this.ecatMark = ecatMark;
            this.currentSemesterFee = currentSemesterFee;
            this.homeTown = homeTown;
            this.isHostilite = isHostilite;
            this.isAvailingSchlarship = isAvailingSchlarship;
        }

        public float calculateMerit()
        {
            float merit = ((0.6f * fscMarks)
                + (0.4f * ecatMark));
            return merit;
        }

        public  bool isEligibleForScholarShip(float meritPercentage)
        {
            if (meritPercentage > 80 && this.isHostilite)
            {
                return true;
            }
            return false;

        }
            
    }

}
