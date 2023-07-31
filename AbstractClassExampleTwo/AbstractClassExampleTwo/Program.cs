using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassExampleTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(3.5);
            Console.WriteLine("Area of Circle is : " + circle.Area());
            Console.WriteLine("Perimeter of Circle is : " + circle.Perimeter());
            Square square = new Square(3.5);
            Console.WriteLine("Area of square:" + square.Area());
            Console.WriteLine("Perimeter of Square: " + square.Perimeter());
            Console.ReadKey();
        }
    }
}
