using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg_Klasser_Automatisk_Egenskaber
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.Fornavn = "Torben";
            p1.Efternavn = "Keller";
            Console.WriteLine($"Enkelt navne fornavn {p1.Fornavn} Efternavn {p1.Efternavn}");
            Console.WriteLine($"Fuldtnavn {p1.FuldtNavn()}");

            Person p2 = new Person();
            p2.Fornavn = "Pia";
            p2.Efternavn = "Kel";
            Console.WriteLine($"Enkelt navne fornavn {p2.Fornavn} Efternavn {p2.Efternavn}");
            Console.WriteLine($"Fuldtnavn {p2.FuldtNavn()}");

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

        private string efternavn;

        public string Efternavn
        {
            get { return this.efternavn; }
            set
            {
                if (value.Length < 4)
                {
                    Console.WriteLine($"Efternavn mindre end 3 {value}, sættes til blank");
                    this.efternavn = "";
                   
                }
                else
                {
                    efternavn = value;
                }
                
            }
        }

   


        public string FuldtNavn()
        {
            return this.Fornavn + " " + this.Efternavn;
        }

    }


}
