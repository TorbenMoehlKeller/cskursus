using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg_Arv_Terning
{
    class Program
    {
        static void Main(string[] args)
        {
            Terning t1 = new Terning();
            t1.Skriv();
            t1.Ryst();
            Console.WriteLine($"Efter ryst {t1.Værdi}");
            LudoTerning lt1 = new LudoTerning();
            lt1.Skriv();
            //t1.Ryst();
            //Console.WriteLine($"Efter ryst {t1.Værdi}");
            //t1.Ryst();
            //Console.WriteLine($"Efter ryst {t1.Værdi}");
            //t1.Ryst();
            //Console.WriteLine($"Efter ryst {t1.Værdi}");
            //t1.Ryst();
            //Console.WriteLine($"Efter ryst {t1.Værdi}");
            //t1.Ryst();
            //Console.WriteLine($"Efter ryst {t1.Værdi}");
            //t1.Ryst();
            //Console.WriteLine($"Efter ryst {t1.Værdi}");
            //t1.Ryst();
            //Console.WriteLine($"Efter ryst {t1.Værdi}");
            //t1.Ryst();
            //Console.WriteLine($"Efter ryst {t1.Værdi}");
            //t1.Ryst();
            //Console.WriteLine($"Efter ryst {t1.Værdi}");
            //t1.Ryst();
            //Console.WriteLine($"Efter ryst {t1.Værdi}");
            //t1.Ryst();
            //Console.WriteLine($"Efter ryst {t1.Værdi}");
            //t1.Ryst();
            //Console.WriteLine($"Efter ryst {t1.Værdi}");
            //t1.Ryst();
            //Console.WriteLine($"Efter ryst {t1.Værdi}");
            //t1.Ryst();
            //Console.WriteLine($"Efter ryst {t1.Værdi}");
            //t1.Ryst();
            //Console.WriteLine($"Efter ryst {t1.Værdi}");
            //t1.Ryst();
            //Console.WriteLine($"Efter ryst {t1.Værdi}");
            //t1.Ryst();
            //Console.WriteLine($"Efter ryst {t1.Værdi}");
            //t1.Ryst();
            //Console.WriteLine($"Efter ryst {t1.Værdi}");
            //t1.Ryst();
            //Console.WriteLine($"Efter ryst {t1.Værdi}");
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
    public class Terning
    {
        private static System.Random rnd;
        private int værdi;

        public Terning()
        {
            this.Ryst();
            Console.WriteLine($"Terning default");
        }

        public Terning(int værdi)

        {

            this.Værdi = værdi;
            Console.WriteLine($"Terning custom");
        }

        static Terning()

        {
            rnd = new Random();
        }

        public Terning(Terning a)
        {
        }

        public int Værdi
        {
            get
            {
                return this.værdi;
            }
            set
            {
                if (value < 1 || value > 6)
                {
                    value = 1;
                }
                this.værdi = value;
            }
        }
        public void Skriv()

        {
            Console.WriteLine($"Terning viser [{this.Værdi}]");
        }
        public void Ryst() => this.Værdi = rnd.Next(1, 7);


    }
    public class LudoTerning : Terning
    {
        public LudoTerning() : base()
        {
            Console.WriteLine($"LudoTerning default");

        }
        public LudoTerning(int værdi) : base(værdi)
        {
            Console.WriteLine($"LudoTerning custom");
        }

        public bool ErGlobus()
        {
            if (Værdi == 3)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public bool ErStjerne()
        {
            if (Værdi == 5)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

    }
}

