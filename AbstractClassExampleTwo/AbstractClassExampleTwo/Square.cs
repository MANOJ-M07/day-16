using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassExampleTwo
{
    public class Square:Shape
    {
        double side;

        public Square(double side)
        {
            this.side = side;
        }

        public override double Area()
        {
            return side * side;
        }

        public override double Perimeter()
        {
            return 4*side;
        }
    }
}
