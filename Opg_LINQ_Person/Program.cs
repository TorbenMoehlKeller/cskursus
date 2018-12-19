using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg_LINQ_Person
{
    class Program
    {
        static void Main(string[] args)
        {

            var r = new PersonNuGetPackage.PersonRepositoryRandom();
            var people = r.GetPeople(30);
            foreach (var person in people)
                Console.WriteLine(person.Name);
            Console.WriteLine();

            var res1 = people.OrderBy(i => i.Name);
            var res1l = from person in people orderby person.Name select person;
            foreach (var person in res1l)
                Console.WriteLine(person.Name);
            Console.WriteLine();

            var res2 = people.OrderBy(i => i.Gender).ThenBy(i => i.Name);
            var res2l = from person in people orderby person.Gender, person.Name select person;
            foreach (var person in res2l)
                Console.WriteLine($"Person navn {person.Name} og køn {person.Gender}");
            Console.WriteLine();

            var res3 = people.Where(i => i.Height < 170);
            var res3l = from person in people where person.Height < 170 select person;
            foreach (var person in res3l)
                Console.WriteLine($"Person navn {person.Name} og køn {person.Gender} < 170 cm");
            Console.WriteLine();

            var res4 = people.Where(i => i.Height <= 170 && i.IsHealthy);
            var res4l = from person in people where person.Height < 170 && person.IsHealthy select person;
            foreach (var person in res4)
                Console.WriteLine($"Person navn {person.Name} og køn {person.Gender} <= 170 cm og sunde");
            Console.WriteLine();

            var res5 = people.GroupBy(i => i.Gender);
            foreach (var grp in res5)
            {
                Console.WriteLine($"Gruppe køn {grp.Key}");
                foreach (var person in grp)
                    Console.WriteLine($"Person navn {person.Name}");
                Console.WriteLine();

            }

            var res6 = people.OrderBy(i => i.Height).Select(i => new { Name = i.Name, Height = i.Height });
            foreach (var person in res6)
                Console.WriteLine($"Person navn {person.Name} og højde {person.Height} i cm ");
            Console.WriteLine();

            int[] range = { 160, 170, 180, 190, 200, 210 };
            var res7 = people.OrderBy(i => i.Height).GroupBy(i => range.FirstOrDefault(x => x > i.Height));
            foreach (var grp2 in res7)
            {
                Console.WriteLine($"Gruppe højde {grp2.Key}");
                foreach (var person in grp2)
                    Console.WriteLine($"Person navn {person.Name} og højde i {person.Height} cm");
                Console.WriteLine();

            }



            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}
