using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c1 = new Car("Ford");
            c1.Make = "Ford";
            c1.Model = "Focus";
            c1.CurrentSpeed = 0;
            c1.EngineSize = 1.2;

            Car c2 = new Car();
            c2.Make = "Opel";
            c2.Model = "Astra";
            c2.CurrentSpeed = 0;
            c2.EngineSize = 1.2;

            c1.DisplayCarInfo();
            Console.WriteLine(c2);

            for (int i = 0; i< 10; i++)
            {
                c1.Accelerate();
            }

            Console.WriteLine("\n"+ c1);
            Console.WriteLine(c2);
        }
    }
}
