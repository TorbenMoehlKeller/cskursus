using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg_Egenskaber_Simpel
{
    class Program
    {
        static void Main(string[] args)
        {

            //Vare v = new Vare("Dæk", 250);
            Vare v = new Vare();
            v.Navn = "Dæk";
            v.Pris = 250;
            Console.WriteLine($"Navn {v.Navn} Pris {v.Pris}");
            v.PrisMedMoms();

            Vare v2 = new Vare("Fælg", 500);
            Console.WriteLine($"Navn {v2.Navn} Pris {v2.Pris}");
            v2.PrisMedMoms();


            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }

    public class Vare
    {
        public Vare()
        {

        }

        public Vare(string navn, double pris)
        {
            this.Navn = navn;
            this.Pris = pris;
        }

        private string navn;

        public string  Navn       {
            get { return navn;  }
            set { navn = value; }
        }

        private double pris;

        public double Pris
        {
            get { return pris; }
            set { pris = value; }
        }

        public double PrisMedMoms()
        {
            double inklMoms = this.pris * 1.25;
            
            Console.WriteLine($"Pris inkl. moms {inklMoms} før moms {this.pris}");
            return inklMoms;
            //return this.pris* 1.25;
        }
    }
}
