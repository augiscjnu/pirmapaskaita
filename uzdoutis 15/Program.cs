using System;
using System.Diagnostics.CodeAnalysis;

namespace uzduotis15
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("iveskite kuro kaina uz litra");
            double A = double.Parse(Console.ReadLine());


            Console.WriteLine("iveskite vidutines kuro sanaudos (litras per 100km) ");
            double B = double.Parse(Console.ReadLine());

            Console.WriteLine("iveskite nuvazuojama atstuma per metus km");
            double C = double.Parse(Console.ReadLine());

            Console.WriteLine("techinines prieziuros islaidos");
            double D = double.Parse(Console.ReadLine());

            Console.WriteLine("draudimo islaidos");
            double E = double.Parse(Console.ReadLine());


            Console.WriteLine("papildomos islaidos");
            double F = double.Parse(Console.ReadLine());


            double kuros = C / B;
            Console.WriteLine($"kuro sanaudos {kuros}");

            double islaidos = D + E + F;
            Console.WriteLine($"technines prieziuros is kitu islaidu suma {islaidos}");

            double bendras = (kuros * A) + islaidos;
            Console.WriteLine($"bendra automobilio eksplotacijos kaina per metus {bendras}");
                                        









        }
    }
}