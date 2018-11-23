using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg_Variabler_DataTime
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime d1;
            d1 = DateTime.Now;

            Console.WriteLine(d1);

            d1 = d1.AddDays(10);
            Console.WriteLine(d1);

            d1 = d1.AddMinutes(20);
            Console.WriteLine(d1);

            d1 = d1.AddMonths(-1);
            Console.WriteLine(d1);

            DateTime d2;
            d2 = DateTime.Now;
            DateTime d3 = new DateTime(1964, 01, 07);

            TimeSpan c1 = d2.Subtract(d3);
            Console.WriteLine($"Antal dage {c1.Days} siden {d3.Year}");

            TimeSpan t2, t3, t4, t5;
            t2 = new TimeSpan(16, 00, 00);
            Console.WriteLine(t2);
            t3 = new TimeSpan(00,30, 00);
            Console.WriteLine(t3);
            t4 = t2 - t3;
            Console.WriteLine(t4);
            t5 = t2.Add(t3);
            Console.WriteLine(t5);



            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }

        }
    }
}
