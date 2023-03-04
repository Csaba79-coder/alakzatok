using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alakzatok
{
    internal class Square : Shape
    {
        public Square(int a) : base(a)
        {

        }

        public double Area()
        {
            return a * a;
        }

        public int Perimeter() { return a * 4; }
    }
}
