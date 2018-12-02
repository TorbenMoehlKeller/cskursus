using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Opg_Metoder_Rekurviv_Filer
{
    class Program
    {
        private const string Path = "H:\\";
        private const string Path2 = @"c:\git";
        static void Main(string[] args)
        {

            PrintFiler(Path);

            // Break ud i kode er også muligt
            // System.Diagnostics.Debugger.Break();

            // Hold Console åbn (ved debug)
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . .");
                Console.ReadKey();
            }
        }

        static void PrintFiler(string sti)
        {
            var filer = Directory.GetFiles(sti);
            foreach (string fil in filer)
            {
                Console.WriteLine(fil);
                var mapper = Directory.GetDirectories(sti);
                foreach (string mappe in mapper)
                {
                    Console.WriteLine(mappe);
                    PrintFiler(mappe);
                }
            };

        }
    }
}
