using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg_Arv_Simpel
{
    class Program
    {
        static void Main(string[] args)
        {

            Person p1 = new Person
            {
                Fornavn = "Person Torben",
                Efternavn = "Person Keller"
            };
            Console.WriteLine($"Personens fornavn {p1.Fornavn}");
            Console.WriteLine($"Personens fulde navn er {p1.FuldtNavn()}");
            Elev e1 = new Elev
            {
                Fornavn = "Elev Torben",
                Efternavn = "Elev Keller",
                Klasselokale = "Elev lokale A"

            };
            Console.WriteLine($"Elevens fulde navn er {e1.FuldtNavn()}");
            Console.WriteLine($"Elevens klasselokale er {e1.Klasselokale}");

            Instruktør i1 = new Instruktør
            {
                Fornavn = "Instruktør Michell",
                Efternavn = "Instruktør Cronberg",
                NøgleId = 1
            };
            Console.WriteLine($"Instruktør fulde navn er {i1.FuldtNavn()}");
            Console.WriteLine($"Instruktør Nøgle ID er {i1.NøgleId}");

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }


        }
    }
    public class Person
    {
        public string Fornavn { get; set; }

        public string Efternavn { get; set; }

        public string FuldtNavn()
        {
            //return this.Fornavn + " " + this.Efternavn;
            return $"{Fornavn} {Efternavn}";
        }
    }

    public class Elev : Person
    {
        public string Klasselokale { get; set; }
    }

    public class Instruktør : Person
    {
        public int NøgleId { get; set; }
    }
}

