using problem_4.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem_4.DL
{
    public class shpesDl
    {
        List<Shapes> shapes = new List<Shapes>();

        public void addShape(Shapes s)
        {
            shapes.Add(s);
        }
    }
}
