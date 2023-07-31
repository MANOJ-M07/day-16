using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Smartphone smartphone = new Smartphone("XYZ-123");
            smartphone.Connect();
            smartphone.Charge(120); // Charging for 120 minutes
            Console.WriteLine(smartphone.Display());

            Laptop laptop = new Laptop("ABC");
            laptop.Connect();
            laptop.Charge(90); // Charging for 90 minutes
            Console.WriteLine(laptop.Display());
            Console.ReadKey();
        }
    }
}
