using System;
using System.Diagnostics.CodeAnalysis;

namespace uzdoutis4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("iveskite pirma sveikaji skaiciu");
            int pirma = int.Parse(Console.ReadLine());

            Console.WriteLine("iveskite antra sviekaji skaiciu");
            int antra = int.Parse(Console.ReadLine());

            int suma = pirma + antra;
            Console.WriteLine($"suma {suma}");

            int skirtumas = pirma - antra;
            Console.WriteLine($"skirtumas {skirtumas}");

            double dalyba = (double)pirma / antra;
            Console.WriteLine($"dalyba {dalyba} ");

            int sandauga = pirma * antra;
            Console.WriteLine($"sandauga {sandauga}");

            int pirmoKvadratas = pirma * pirma;
            Console.WriteLine($"pirmo skaiciaus kvadratas {pirmoKvadratas}");

            int antroKvadratas = antra * antra;
            Console.WriteLine($"antro skiaciaus kvadratas {antroKvadratas}");



        }
    }
}