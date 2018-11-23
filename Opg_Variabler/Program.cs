using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg_Variabler
{
    class Program
    {
        static void Main(string[] args)
        {
            int heltal = 0;

            heltal++;
            Console.WriteLine($"Heltal værdi {heltal}");

            heltal--;
            Console.WriteLine($"Heltal værdi {heltal}");

            heltal+=20;
            Console.WriteLine($"Heltal værdi {heltal}");

            double kommatal = 12.5;

            kommatal++;
            Console.WriteLine($"Kommatal værdi {kommatal}");

            kommatal--;
            Console.WriteLine($"Kommatal værdi {kommatal}");

            kommatal *= 2;
            Console.WriteLine($"Kommatal værdi {kommatal}");


            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }

        }
    }
}
