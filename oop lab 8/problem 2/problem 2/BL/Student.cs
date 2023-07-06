using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace problem_2.BL
{
    public class Student:Person
    {
        public string progranm;
        public int year;
        public double fee;

        public Student(string progranm, int year, double fee,string name,string address):base(name, address)
        {
            this.progranm = progranm;
            this.year = year;
            this.fee = fee;
            this.name = name;
            this.address = address; 
        }

        public override string toString()
        {
            string pInfo = "name is " + name + "program is " + progranm + "year is " + year + "fee is " + fee + "adddrss is " + address;
            return pInfo;
        }
    }
}
