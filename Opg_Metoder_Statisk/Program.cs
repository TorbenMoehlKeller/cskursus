using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Opg_Metoder_Statisk
{
    class Program
    {
        private const string Path = "C:\\temp\\";
        private const string Fil = "test.txt";
        static void Main(string[] args)
        {

            if (File.Exists(Path + Fil))
            {
                Console.WriteLine("Filen findes");
                string readfile = File.ReadAllText(Path + Fil);
                Console.WriteLine($"Læst fra fil: {readfile}");

                var fil = new FileInfo(Path + Fil);
                string accesstime = fil.LastAccessTime.ToString();
                Console.WriteLine($"Access time som string: {accesstime}");
                string ext = fil.Extension.ToString();
                Console.WriteLine($"Extension som string: {ext}");

            }
            else
            {
                Console.WriteLine("Filen findes ikke");
            }

            //File.ReadAllText.filnavn(Path + "test.txt");


            // Break ud i kode er også muligt
            // System.Diagnostics.Debugger.Break();

            // Hold Console åbn (ved debug)
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . .");
                Console.ReadKey();
            }
        }
    }
}
