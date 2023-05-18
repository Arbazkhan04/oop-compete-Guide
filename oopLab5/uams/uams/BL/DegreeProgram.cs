using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uams.BL
{
    public class DegreeProgram
    {
        public string degreeProgam;
        public float degreeDuration;
        public List<Subject> subject;
        public int seat;

        public DegreeProgram(string degreeProgam, float degreeDuration, int seat)
        {
            this.degreeProgam = degreeProgam;
            this.degreeDuration = degreeDuration;
            this.subject = new List<Subject>();
            this.seat = seat;
        }


        public int getCreditHour()
        {
            int count = 0;
            for(int i = 0; i < subject.Count; i++)
            {
                count = count + subject[i].creditHour;

            }
            return count;
        }

        public bool addSubject(Subject sub)
        {
            int creditHour = getCreditHour();
            if (creditHour + sub.creditHour <= 20)
            {
                subject.Add(sub);
                return true;
            }
            return false;
        }

        public bool isSubjectExist(Subject s)
        {
            foreach(Subject sub in subject)
            {
                if (s.code == sub.code)
                {
                    return true;
                }

            }
            return false;
        }
    }
}
