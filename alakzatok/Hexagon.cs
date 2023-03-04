using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alakzatok
{
    internal class Hexagon : Shape
    {
        public Hexagon(int a) : base(a) { 
        }


        public double Area()
        {
            return 3 / 2 * a * a * Math.Sqrt(3);
        }

        public int Perimeter()
        {
            return a * 6;
        }
    }
}