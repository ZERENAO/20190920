using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20190920
{
    class Program
    {
        static Random rnd = new Random();
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
            Console.WriteLine("Nesze itt van 100 csillag");
            for (int i = 0; i < 100; i++)
            {
                Console.SetCursorPosition(
                    rnd.Next(Console.WindowWidth),
                    rnd.Next(Console.WindowHeight));
                Console.ForegroundColor = (ConsoleColor)rnd.Next(1, 16);
                Console.Write("*");
            }
            Console.ReadKey();
        }
    }
}
