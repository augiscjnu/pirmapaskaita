using System;
using System.Diagnostics.CodeAnalysis;

namespace uzduotis13
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("iveskite suma Litais");
            double L = double.Parse(Console.ReadLine());

            double eur = L / 3.4528;
            Console.WriteLine($"suma Eurais {eur}");

            double dol = eur / 0.93;
            Console.WriteLine($"suma doleriais {dol}");

            double svaras = dol / 1.31;
            Console.WriteLine($"suma svairais {svaras}");









        }
    }
}