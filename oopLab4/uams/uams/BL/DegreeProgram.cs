using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uams.BL
{
    internal class DegreeProgram
    {
        public String DegreeName;
        public int duration;
        public int seatForDegee;
        public Subject subject;

        List<DegreeProgram> degreeProgramList = new List<DegreeProgram>();
        public DegreeProgram(string degreeName, int duration, int seatForDegee, Subject subject)
        {
            DegreeName = degreeName;
            this.duration = duration;
            this.seatForDegee = seatForDegee;
            this.subject = subject;
        }

        public void addDegreeProgam(DegreeProgram dP)
        { degreeProgramList.Add(dP);
        }
    }
}
