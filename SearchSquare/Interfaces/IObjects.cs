using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchSquare.Interfaces
{
    internal interface IObjects
    {
        public List<string> NamesOfFigure { get;}
        public string Triangle(double x, double y, double z);
        public string Circle(double r);

    }
}
