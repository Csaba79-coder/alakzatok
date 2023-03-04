using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alakzatok
{
    internal class Triangle : Shape
    {
        private int magassag;
        public Triangle(int a, int magassag) : base(a)
        {
            this.magassag = magassag;
        }
        public double Area()
        {
            return a * magassag / 2;
        }

        public int Perimeter()
        {
            return a * 3;
        }
    }
    
}
