using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg_Interface_Eget
{
    class Program
    {
        static void Main(string[] args)
        {
            Hund h = new Hund() { Navn = "Figo" };
            h.Gem();

            Ubåd u = new Ubåd() { Nummer = 1, Turbine = 2000 };
            u.Gem();

            IDbFunktioner[] iar = new IDbFunktioner[6];
            iar[0] = new Hund() { Navn = "Figo igen igen" };
            iar[1] = new Ubåd();
            iar[2] = new Hund();
            iar[3] = new Ubåd();
            iar[4] = new Ubåd() { Nummer = 3, Turbine = 5555 };
            iar[5] = new Hund();

            foreach (var item in iar)
            {
                item.Gem();
            }

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
    class Hund : IDbFunktioner 
    {
        public string Navn { get; set; }

        public void Gem()
        {
            Console.WriteLine($"Gemmer Hund {Navn}");
        }
    }

    class Ubåd : IDbFunktioner
    {
        public int Nummer { get; set; }
        public double Turbine { get; set; }

        public void Gem()
        {
            Console.WriteLine($"Gemmer Ubåd nr {Nummer} og turbine {Turbine}");
        }
    }

    interface IDbFunktioner
    {
        void Gem();
    }
}
