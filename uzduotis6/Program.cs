using System;
using System.Diagnostics.CodeAnalysis;

namespace uzduotis6
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("iveskite temperatura (C)");
            int temp = int.Parse(Console.ReadLine());

            double F = (1.8 * temp) + 32;
            Console.WriteLine($"Farenheito laipsnai {F}");




        }
    }
}