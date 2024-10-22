using System;
using System.Diagnostics.CodeAnalysis;

namespace uzduotis12
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("iveskite skaiciu");
            double A = double.Parse(Console.ReadLine());

            Console.WriteLine("iveskite procenta");
            double proc = double.Parse(Console.ReadLine());

            double b = (A/100) * proc;
            Console.WriteLine($"skaiciaus procentai {b}");





        }
    }
}