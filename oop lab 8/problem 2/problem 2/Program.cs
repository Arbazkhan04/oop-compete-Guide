using problem_2.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("khan", 123, 12.34F, "abc", "bscs");
            s1.toString();
            Student s2 = new Student("khan", 123, 12.34F, "abc", "bscs");
            s2.toString();
        }
    }
}
