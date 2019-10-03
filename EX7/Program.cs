using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX7
{
    class Program
    {
        static void Main(string[] args)
        {
            Enrollment school1,school2, school3, school4,school5;

            school1 = new Enrollment();
            school2 = new Enrollment();
            school3 = new Enrollment();
            school4 = new Enrollment();
            school5 = new Enrollment();


            Write("Enter school name: ");
            school1.School = ReadLine();
            Write("Enter enrollment: ");
            school1.Num = int.Parse(ReadLine());

            Write("Enter school name: ");
            school2.School = ReadLine();
            Write("Enter enrollment: ");
            school2.Num = int.Parse(ReadLine());

            Write("Enter school name: ");
            school3.School = ReadLine();
            Write("Enter enrollment: ");
            school3.Num = int.Parse(ReadLine());

            Write("Enter school name: ");
            school4.School = ReadLine();
            Write("Enter enrollment: ");
            school4.Num = int.Parse(ReadLine());

            Write("Enter school name: ");
            school5.School = ReadLine();
            Write("Enter enrollment: ");
            school5.Num = int.Parse(ReadLine());
            WriteLine();

            Display(school1,school2,school3,school4,school5);
        }
        static void Display(params Enrollment[] schools)
        {
            foreach (Enrollment school in schools)
            {
                Console.WriteLine("{0,-24}{1,-12}",school.School,school.Num);
            }

        }

    }

}
