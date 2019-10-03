using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX5
{
    class CashRegister
    {
        public int NumberOfItems { get; private set; }
        public static int TotalItems { get; set; }
        public double Total { get; private set; }
        public static double TotalCost { get; set; }

        public void AddItem(double itemPrice)
        {
            Total += itemPrice;
            TotalCost += itemPrice;

            NumberOfItems++;
            TotalItems++;

        }
    }

}
