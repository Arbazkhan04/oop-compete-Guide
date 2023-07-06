using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace problem_2.BL
{
    public class Staff:Student
    {
        public string school;
        public double pay;

        public Staff(string school, double pay,string name,string address,string program,int year,double fee):base(program,year,fee,name,address)
        {
            this.school = school;
            this.pay = pay;
            this.name = name;
            this.address = address;
            this.progranm=program;
            this.fee = fee;
            this.year = year;
        }

        public override string toString()
        {
            string pInfo = "name is " + name + "program is " + progranm + "year is " + year + "fee is " + fee + "adddrss is " + address + "school is"+school + " pay is "+ pay;
            return pInfo;
        }
    }
}
