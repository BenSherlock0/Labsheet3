using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            CashRegister cr1 = new CashRegister();
            CashRegister cr2 = new CashRegister();

            cr1.AddItem(2.70);
            cr1.AddItem(3.45);
            cr1.AddItem(5.97);

            cr2.AddItem(12.52);
            cr2.AddItem(1.43);
            cr2.AddItem(15.57);
            cr2.AddItem(5.15);

            Console.WriteLine("Cash Register CR1 Total: {0:C}", cr1.Total);
            Console.WriteLine("Cash Register CR1 Num of items: {0}", cr1.NumberOfItems);

            Console.WriteLine("Cash Register CR2 Total: {0:C}", cr2.Total);
            Console.WriteLine("Cash Register CR2 Num of items: {0}", cr2.NumberOfItems);

        }
    }
}
