using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal interface IAccount
    {
        double Balance { get; }

        double Deposit(double amount);

        double WithDraw(double amount);
    }
}
