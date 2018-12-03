using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg_Klasser_Simpel
{
    class Program
    {
        static void Main(string[] args)
        {

            Person p1 = new Person("Torben", "Keller", 1964);
            Console.WriteLine($"Fuldt navn {p1.FuldtNavn()}");
            Console.WriteLine($"Alder {p1.Alder()}");
           

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }

        public class Person
        {
            public string Fornavn;
            public string Efternavn;
            public int Fødselsår;
            public Person()
            {
                this.Fornavn = "";
                this.Efternavn = "";
            }


            public Person(string fornavn, string efternavn, int fødselsår)
            {
                this.Fornavn = fornavn;
                this.Efternavn = efternavn;
                
                if (fødselsår < 1900)
                {
                    //throw new ApplicationException($"Du er for for gammel!!!!");
                    Console.WriteLine($"Du er for for gammel!!!!" );
                }
                else
                {
                    this.Fødselsår = fødselsår;
                }

            }
            public string FuldtNavn() => $"{this.Fornavn} {this.Efternavn}";
            //public string FuldtNavn() => this.Fornavn + " " + this.Efternavn;

            public int Alder()
            {
                int år = DateTime.Now.Year;
                return år - this.Fødselsår;
            }
        }
    }
}
