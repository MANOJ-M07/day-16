using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class SavingsAccount:IAccount
    {
        double sBal;

        public SavingsAccount()
        {
            sBal = 20000;
        }

        public double Balance => sBal;

        public double Deposit(double amount)
        {
            sBal += amount;
            return sBal;
        }

        public double WithDraw(double amount)
        {
            if(amount <= sBal)
            {
                if(sBal - amount>=500)
                {
                    sBal -= amount;
                    Console.WriteLine("Transcation Sucess");
                }
                else
                {
                    Console.WriteLine("minimum balence have to maintain 5000");
                }
            }
            else
            {
                Console.WriteLine("Insufficient Balaence");
                Console.WriteLine("Transaction Failed");
            }
            return sBal;
        }
    }
}
