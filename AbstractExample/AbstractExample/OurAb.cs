using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractExample
{
    public abstract class OurAb
    {
        int myField;

        public OurAb()
        {
            Console.WriteLine("Abstract class constructor");
        }

        
        public int MyProperty { get { return myField; } set{ myField = value; } }

        public void Display()
        {
            Console.WriteLine("Display of Abstract Class");
        }
        
        public abstract void Welcome(string name);

        public abstract string AbProp { get; set; }
    }

}
