using System;

namespace Opg_Metoder_Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            bool? res;
            res = HentFraDb(1);
            Console.WriteLine($"resultat: {res}");

            res = HentFraDb(2);
            Console.WriteLine($"resultat: {res}");

            res = HentFraDb(3);
            Console.WriteLine($"resultat: {res}");



            // Break ud i kode er også muligt
            // System.Diagnostics.Debugger.Break();

            // Hold Console åbn (ved debug)
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . .");
                Console.ReadKey();
            }
        }
        static bool? HentFraDb (int tal)
        {
            if (tal == 1)
                return true;
            if (tal == 2)
                return false;
            return null;

        }
    }
}
