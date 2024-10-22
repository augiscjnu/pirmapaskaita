using System;

namespace uzduotis3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("iveskite trikampio pagrindo ilgi (cm): ");
            double pagrindoIlgis = double.Parse(Console.ReadLine());

            Console.WriteLine("iveskite trikampio auksti (cm): ");
            double trikampioAukstis = double.Parse(Console.ReadLine());

            double trikampioPlotas = (pagrindoIlgis*trikampioAukstis)/2;
            Console.WriteLine($"trikampio plotas {trikampioPlotas}");
        }
    }
}