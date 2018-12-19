using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg_Events_FileWatcher
{
    class Program
    {
        static void Main(string[] args)
        {
            System.IO.FileSystemWatcher w = 
            new System.IO.FileSystemWatcher(@"c:\temp", "*.txt");
            w.EnableRaisingEvents = true;
            w.Changed += W_Changed;
            w.Created += (s, e) => { Console.WriteLine($"Fil {e.Name} oprettet i sti {e.FullPath}"); };
            w.Created += (s, e) => { Console.WriteLine($"Fil {e.Name} oprettet i sti {e.FullPath}"); };
            w.Deleted += (s, e) => { Console.WriteLine($"Fil {e.Name} slettet i sti {e.FullPath}"); };
            w.Renamed += (s, e) => { Console.WriteLine($"Fil {e.Name} renamed fra {e.OldName}"); };


            do
            { } while (true);

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }

        private static void W_Changed(object sender, System.IO.FileSystemEventArgs e)
        {
            Console.WriteLine($"Filen {e.Name} er rettet");
        }
    }
}
