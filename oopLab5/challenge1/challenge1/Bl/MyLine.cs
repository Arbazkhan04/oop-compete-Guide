using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge1.Bl
{
    internal class MyLine
    {
        public MyPoint begin;
        public MyPoint end;

        public MyLine(MyPoint begin ,MyPoint end) {
            this.begin = begin;
            this.end = end;
        } 

    }
}
