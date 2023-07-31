using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractExample
{
    public class DriveClass:OurAb
    {
        string myporp;

        public override string AbProp { get => myporp; set { myporp = value; } }

        public override void Welcome(string name)
        {
            Console.WriteLine("Welcome to Abstract class"+name);
        }
    }
}
