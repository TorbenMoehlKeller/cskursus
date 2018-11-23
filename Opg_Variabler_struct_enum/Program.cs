using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg_Variabler_struct_enum
{
    class Program
    {
        static void Main(string[] args)
        {

            FilTyper ft = new FilTyper();
            ft = FilTyper.csv;

            Console.WriteLine($"File type: {ft}");
            Console.WriteLine($"File type værdi: {(int)ft}");

            Person p = new Person
            {
                Navn = "Mikkel",
                Id = 1,
                Køn = Køn.Mand
            };

            
            Console.WriteLine($"Navn på person: {p.Navn}");
            Console.WriteLine($"Navn på person: {p.Køn}");

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}
