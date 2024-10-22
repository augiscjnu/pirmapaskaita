using System;
using System.Diagnostics.CodeAnalysis;

namespace uzduotis5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("iveskite pirma sveikaji skaiciu");
            int pirma = int.Parse(Console.ReadLine());

            Console.WriteLine("iveskite antra sviekaji skaiciu");
            int antra = int.Parse(Console.ReadLine());

            Console.WriteLine("iveskite trecia sviekaji skaiciu");
            int trecia = int.Parse(Console.ReadLine());

            int vidurkis = (pirma + antra + trecia) / 3;
            Console.WriteLine($"vidurkis {vidurkis}");



        }
    }
}