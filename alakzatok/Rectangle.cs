using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alakzatok
{
    internal class Rectangle : Shape
    {
        private int b;
        public Rectangle(int a, int b) : base(a)
        {
            this.b = b;
        }

        public double Area()
        {
            return a * b;
        }

        public double Perimeter()
        {
            return a * 2 + b * 2;
        }
    }
}
