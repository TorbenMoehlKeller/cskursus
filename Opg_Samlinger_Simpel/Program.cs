using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg_Samlinger_Simpel
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Transaction> lt1 = new List<Transaction>();
            lt1.Add(new Transaction() { TradeId = "5218ABCDEF", Amount = 500.35 });
            lt1.Add(new Transaction() { TradeId = "6524dfghfv", Amount = 777.66 });
            lt1.Add(new Transaction() { TradeId = "4578plkjfk", Amount = 666.88 });

            foreach(var x in lt1)
            {

                Console.WriteLine($"TradeId {x.TradeId} Beløb {x.Amount}");
            }

            Dictionary<int, Transaction> dic1 = new Dictionary<int, Transaction>();
            dic1.Add(1, new Transaction() { TradeId = "fdsfdsgf", Amount = 5006123.3 });
            dic1.Add(2, new Transaction() { TradeId = "dhdhdtgf", Amount = 56565.343 });
            dic1.Add(3, new Transaction() { TradeId = "frstgrtg", Amount = 58795.343 });


            foreach (var item in dic1)
            {
                Console.WriteLine($"Nøgle {item.Key}, TradeID {item.Value.TradeId} Beløb {item.Value.Amount}");
            }

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
    public class Transaction
    {
        public string TradeId { get; set; }
        public double Amount { get; set; }

    }
    
}
