using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uams.BL
{
    internal class Subject
    {
        public int subjectCode;
        public String subjectType;
        public int creditHour;
        public int subjectFee;

        public Subject(int subjectCode, string subjectType, int creditHour, int subjectFee)
        {
            this.subjectCode = subjectCode;
            this.subjectType = subjectType;
            this.creditHour = creditHour;
            this.subjectFee = subjectFee;
        }
    }
}
