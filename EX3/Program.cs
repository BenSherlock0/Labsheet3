using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            BankAccount acc1 = new BankAccount("45682012", "Tom Smith",1000);
            BankAccount acc2 = new BankAccount("75587891", "Mary Mills", 2000);

            Console.WriteLine(acc1.GetAccountDetails());
            Console.WriteLine(acc1.GetAccountDetails());

            Console.WriteLine("Adding €1000 to acc1");
            acc1.Deposit(1000);

            Console.WriteLine("Withdrawing €500 from acc2\n");
            acc2.WithDraw(500);

            Console.WriteLine(acc1.GetAccountDetails());
            Console.WriteLine(acc2.GetAccountDetails());

        }
    }
}
