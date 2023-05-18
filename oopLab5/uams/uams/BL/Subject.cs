using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uams.BL
{
    public class Subject
    {
        public string code;
        public string type;
        public int creditHour;
        public int subejctFee;

        public Subject(string code, string type, int creditHour, int subejctFee)
        {
            this.code = code;
            this.type = type;
            this.creditHour = creditHour;
            this.subejctFee = subejctFee;
        }
    }
}
