using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg_Fejlhåndtering_Egen_Exception
{
    class Program
    {
        static void Main(string[] args)
        {

            string sti = @"c:\temp\tal.txt";

            if (!System.IO.File.Exists(sti))
            {
                throw new ApplicationException($"Fil {sti} findes ikke");
            }

            string indhold = "";
            indhold = System.IO.File.ReadAllText(sti);
            System.IO.File.
          

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}
