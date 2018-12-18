using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg_Interface_Compare
{
    class Program
    {
        static void Main(string[] args)
        {
            Hund[] hunde = new Hund[3];
            hunde[0] = new Hund() { Alder = 10, Navn = "Bulder" };
            hunde[1] = new Hund() { Alder = 5, Navn = "Lady" };
            hunde[2] = new Hund() { Alder = 5, Navn = "Figo" };
            Array.Sort(hunde);
            foreach (var item in hunde)
            {
                Console.WriteLine(item.Navn);
            }
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
    class Hund : IComparable<Hund>
    {
        public string Navn { get; set; }
        public int Alder { get; set; }


        public int CompareTo(Hund h)
        {
            if (this.Alder > h.Alder)
                return 1;
            if (this.Alder < h.Alder)
                return -1;
            return(string.Compare(this.Navn, h.Navn));
        }
    }
}
