using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg_Metoder_Rekursiv
{
    class Program
    {
        static void Main(string[] args)
        {

            RekursivMetode(1, 10);
            RekursivMetode2(1, 10);
            // Break ud i kode er også muligt
            // System.Diagnostics.Debugger.Break();

            // Hold Console åbn (ved debug)
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . .");
                Console.ReadKey();
            }
        }


        static void RekursivMetode(int start, int stop)
        {
            Console.WriteLine(start);
            if (start == stop)
                return;
            start++;
            RekursivMetode(start, stop);
        }

        static void RekursivMetode2(int start, int stop)
        {
            if (start <= stop)
            {
                Console.WriteLine($"Næste nr. er: {start}");
                start++;
                RekursivMetode2(start, stop);
            }
            else
            {
                Console.WriteLine($"Så er Stop værdien nået: {stop}");
            }
        }
    }
}
