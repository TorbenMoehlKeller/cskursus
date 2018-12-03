using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg_Hukommelse
{
    class Program
    {
        static void Main(string[] args)
        {

            Person k1 = new Person();
            Person k2 = new Person();
            k1.Navn = "a";
            k2.Navn = "b";

            Console.WriteLine($"Navn på person k1 {k1.Navn}");
            Console.WriteLine($"Navn på person k2 {k2.Navn}");
            k1 = k2;
            Console.WriteLine($"Navn på person k1 {k1.Navn}");
            Console.WriteLine($"Navn på person k2 {k2.Navn}");

            k1.Navn = "c";
            Console.WriteLine($"Navn på person k1 {k1.Navn}");
            Console.WriteLine($"Navn på person k2 {k2.Navn}");


            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }

        class Person
        {
            public string Navn;
      
        }
    }
}
