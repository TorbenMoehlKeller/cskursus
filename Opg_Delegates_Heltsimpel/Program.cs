using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg_Delegates_Heltsimpel
{
    //public delegate void MinDelegate1(string str1);

    class Program
    {
        static void Main(string[] args)
        {
            //MinDelegate1 f1 = new MinDelegate1(MinSkrivTilConsole);
            Action<string> f1 = MinSkrivTilConsole;
            f1.Invoke("test1");
            Console.WriteLine();
            f1 -= MinSkrivTilConsole;
            if (f1 != null)
                f1("test1");
            else
            {
                Console.WriteLine($"f1 har ikke længere nogen reference");
            }
            Console.WriteLine();

            //MinDelegate1 f2 = MinSkrivTilConsole;
            Action<string> f2 = MinSkrivTilConsole;
            f2("test2");
            Console.WriteLine();
            f2?.Invoke("test2 med ? for null");
            f2 -= MinSkrivTilConsole;
            f2?.Invoke("test2 med ? for null");

            if (f2 != null)
               f2("test2");
            else
            {
                Console.WriteLine($"f2 har ikke længere nogen reference");
            }
            Console.WriteLine( );

            try
            {

                f2("test2");
            }
            catch (NullReferenceException)
            {
                Console.WriteLine($"f2 har ikke længere nogen reference - try catch");
            }
            Console.WriteLine();

            
            //MinDelegate1 f3 = MinSkrivTilConsole;
            Action<string> f3 = MinSkrivTilConsole;
            f3 += Console.WriteLine;
            f3("test3");
            Console.WriteLine();

            f3 -= Console.WriteLine;
            f3("test3");

            Console.WriteLine();
            f3 -= MinSkrivTilConsole;
            if (f3 != null)
                f3("test3");
            else
            {
                Console.WriteLine($"f3 har ikke længere nogen reference");
            }


            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
        static void MinSkrivTilConsole(string txt)
        {
            Console.WriteLine($"**** {txt} ****");
        }
    }
}
