using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    /*public class OurClass: IMyInterface, IMyInterfaceTwo
    {
        public void Display()
        {
            Console.WriteLine("Display of IMyinterface");
        }

        public void Welcome(string name)
        {
            Console.WriteLine("Welcome to Interface");
        }
    }*/

    public class OurClass: IMyInterface, IMyInterfaceTwo
    {
        void IMyInterface.Display()
        {
            Console.WriteLine("Interface one's display");
        }

        void IMyInterfaceTwo.Dispaly()
        {
            Console.WriteLine("Interface two's display");
        }
    }
}
