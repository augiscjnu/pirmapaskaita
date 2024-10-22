using System;
using System.Diagnostics.CodeAnalysis;

namespace uzduotis9
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("iveskite nuvaziuta atstuma km");
            int atsumas = int.Parse(Console.ReadLine());

            Console.WriteLine("iveskite laika per kuri nuvazuotas atsumas H");
            int laikas = int.Parse(Console.ReadLine());

            double greitis = atsumas / laikas;
            Console.WriteLine($"grietis {greitis}");






        }
    }
}