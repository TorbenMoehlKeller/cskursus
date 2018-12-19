using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg_Delegates_Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> a = new List<int>() { 5, 1, 1, 51, 7, 1, 56, 36, 5 };
            Console.WriteLine();
            Console.WriteLine($"Position i listen {a.FindIndex(FindVærdi)}");
            Console.WriteLine($"Værdi i listen {a[a.FindIndex(FindVærdi)]}");
            Console.WriteLine(a.FindIndex((i) => { return i == 51; } ));
            Console.WriteLine(a.FindIndex(i =>  i == 51 ));

            Console.WriteLine();
            a.ForEach(ListVærdi);

            Console.WriteLine();
            a.ForEach(i => { Console.WriteLine(i); });

            Console.WriteLine();
            a.ForEach(i => Console.WriteLine(i) );

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }

        static bool FindVærdi(int i)
        {
            return i == 51;
        }

        static void ListVærdi(int i)
        {
            Console.WriteLine(i);
        }
    }
}
