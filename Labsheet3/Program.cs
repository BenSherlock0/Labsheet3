using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labsheet3
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c1 = new Car();
            c1.Make = "Ford";
            c1.Model = "Focus";
            c1.CurrentSpeed = 0;
            c1.EngineSize = 1.2;

            Car c2 = new Car();
            c2.Make = "Opel";
            c2.Model = "Astra";
            c2.CurrentSpeed = 0;
            c2.EngineSize = 1.2;

            Console.WriteLine($"The {c1.Make} {c1.Model}, engine size {c1.EngineSize} is currently travelling at {c1.CurrentSpeed}KM/H.");

            Console.WriteLine($"The {c2.Make} {c2.Model}, engine size {c2.EngineSize} is currently travelling at {c2.CurrentSpeed}KM/H.");
        }
    }
}
