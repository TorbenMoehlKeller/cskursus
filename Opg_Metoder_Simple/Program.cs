using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg_Metoder_Simple
{
    class Program
    {
        static void Main(string[] args)
        {

            int res = LægSammen(5, 2);
            Console.WriteLine($"Sum: {res}");

            int radius = 5;
            double areal = BeregnAreal(radius);
            Console.WriteLine($"Cirkel areal: {areal} ved radius {radius}");

            string tekst = ( $"Cirkel areal: {areal} ved radius {radius}" );


            Udskriv(tekst);

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . .");
                Console.ReadKey();
            }
        }

        static int LægSammen(int a, int b) => a + b;

        static double BeregnAreal(int radius)
        {
            double areal = ( radius * radius * Math.PI );
            return areal;
        }

        static void Udskriv(string txt = "Tom tekst")
        {
            Console.WriteLine(txt);
        }

    }
}
