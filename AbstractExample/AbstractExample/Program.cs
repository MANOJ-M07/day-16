using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //OurAb obj = new OurAb();
            //Error can not create object of abstract class
            DriveClass obj = new DriveClass();
            obj.Welcome("sam");
            obj.Display();
            Console.ReadKey();
        }
    }
}
