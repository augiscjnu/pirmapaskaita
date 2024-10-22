using System;
using System.Diagnostics.CodeAnalysis;

namespace uzduotis7
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("iveskite savo svori (kg)");
            int svoris = int.Parse(Console.ReadLine());

            Console.WriteLine("iveskite savo ugi (m)");
            int ugis = int.Parse(Console.ReadLine());

            double KMI = (ugis * ugis) / svoris;
            Console.WriteLine($"kuno mases indeksas {KMI}");




        }
    }
}