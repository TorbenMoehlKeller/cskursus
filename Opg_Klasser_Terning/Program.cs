using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg_Klasser_Terning
{
    class Program
    {
        static void Main(string[] args)
        {

            Terning t1 = new Terning();
            t1.Skriv();
            t1.Ryst();
            t1.Skriv();

            Terning t2 = new Terning(false);
            t2.Skriv();
            t2.Ryst();
            t2.Skriv();

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
        public class Terning
        {
            public int Værdi;
            private bool Snyd;

            private static Random Rnd = new Random();

            public Terning ()
            {
                this.Værdi = 1;
                this.Snyd = false;  
            }

            public Terning(bool snyd)
            {

                this.Snyd = snyd;
                Ryst();
            }

            public void Skriv()
            {
                 Console.WriteLine($"[{this.Værdi}]");
         
            }
            public void Ryst()
            {
                if (Snyd == true)
                    this.Værdi = 6;
                else
                    this.Værdi = Rnd.Next(1, 7);
                  

            }
        }
    }
}
