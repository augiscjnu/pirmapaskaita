using System;
using System.Diagnostics.CodeAnalysis;

namespace uzduotis8
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("iveskite valandu skaiciu");
            int H = int.Parse(Console.ReadLine());

            int min = H * 60;
            Console.WriteLine($"minutes {min}");

            int s = min * 60;
            Console.WriteLine($"sekundes {s}");






        }
    }
}