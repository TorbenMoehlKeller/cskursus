using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg_Arv_Polymorfi_Dyr
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dyr d = new Dyr() { Navn = "Preben" };
            //d.SigNoget();
            Hund h = new Hund() { Navn = "Figo" };
            h.SigNoget();

            Kat k = new Kat() { Navn = "Nulle" };
            k.SigNoget();

            Dyr[] dyr = new Dyr[20];
            for (int i = 0; i < 20; i++)
            {
                dyr[i] = Dyr.TilfældigtDyr();
            }

            foreach (var item in dyr)
            {
                item.SigNoget();
            }

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
    abstract class Dyr
    {
        static System.Random rnd = new Random();
        private string navn;

        public string Navn
        {
            get { return navn; }
            set { navn = value; }
        }

        public virtual void SigNoget()
        {
            Console.WriteLine($"Jeg er et dyr og hedder {Navn}");
        }
        public static Dyr TilfældigtDyr()

        {
            string data = "Freja;Bella;Emma;Mille;Fie;Molly;Lady;Trine;Trunte;Luna;Amanda;";
            data += "Bonnie;Laika;Ronja;Sally;Trille;Zita;Tøsen;Bianca;Zenta;Victor;Buller;";
            data += "Buster;King;Simba;Thor;Charlie;Samson;Bamse;Mickey;Max;Rasmus;Sofus;Anton;";
            data += "Laban;Basse;Bølle;Oliver;Oscar;Balder";

            string[] navne = data.Split(';');
            int index = rnd.Next(0, navne.Length);

            if (index % 2 == 0)
            {
                return new Hund() { Navn = navne[index] };
            }
            else
            {
                return new Kat() { Navn = navne[index] };
            }
        }
    }
    class Hund : Dyr
    {

        public override void SigNoget()
        {
            Console.WriteLine($"Jeg er en hund og hedder {Navn}");
        }
    }
    class Kat : Dyr
    {

        public override void SigNoget()
        {
            Console.WriteLine($"Jeg er en kat og hedder {Navn}");
        }
    }

}
