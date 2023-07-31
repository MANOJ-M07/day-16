using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IAccount account = null;
            Console.WriteLine("Choose Account type");
            Console.WriteLine("1.saving 2. current");
            int acType = int.Parse(Console.ReadLine());
            switch (acType)
            {
                case 1:
                    {
                        account = new SavingsAccount();
                        break;
                    }
                case 2:
                   {
                        account = new CurrentAccount();
                        break;
                   }
                    default: { return; }
            }
            Console.WriteLine("choose operation 1.Balance 2. deposit 3. Withdraw");
            int operation = int.Parse(Console.ReadLine());
            switch (operation)
            {
                case 1:
                    {
                        Console.WriteLine(account.Balance);
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine(account.Deposit(1200));
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine(account.WithDraw(1200));
                        break;
                    }
                default:
                    {
                        Console.WriteLine("invalid operation");
                        break;
                    }
            }
            Console.ReadKey();
        }
    }
}
