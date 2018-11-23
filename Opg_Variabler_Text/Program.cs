using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg_Variabler_Text
{
    class Program
    {
        private const string Path = "C:\\temp\\";

        static void Main(string[] args)
        {

            string fornavn = "Mikkel";
            string efternavn = "Cronberg";

            string samletNavn = fornavn + " " + efternavn;
            Console.WriteLine(samletNavn);

            string navnStort = samletNavn.ToUpper();
            Console.WriteLine(navnStort);

            string navnLille = samletNavn.ToLower();
            Console.WriteLine(navnLille);

            string strengDel = samletNavn.Substring(7, 4);
            Console.WriteLine(strengDel);

            string a = "\t" + fornavn + "\t" + efternavn + "\r\n" + navnStort;
            Console.WriteLine($"a = {a}");

            File.WriteAllText(Path+"myfile.txt", samletNavn);
            File.WriteAllText(Path+"myfile2.txt ", a);

            

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }

            ;
        }
    }
}
