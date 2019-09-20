using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20190920
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Szia, hogy hívnak?");
            var n = Console.ReadLine();
            Console.WriteLine($"Ó, milyen szép név az hogy {n}!");
            Console.WriteLine($"Szerecc pogramozni {n}? :3");
            var v = Console.ReadLine();
            if(v.ToLower() == "igen")
            {
                Console.WriteLine("Szuper, akkor örökké barátok leszünk C:");
            }
            else
            {
                Console.WriteLine("Akkor kabbe!");
            }
            Console.ReadKey();
        }
    }
}
