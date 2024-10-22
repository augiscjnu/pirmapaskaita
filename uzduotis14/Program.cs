using System;
using System.Diagnostics.CodeAnalysis;

namespace uzduotis14
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("iveskite savo metines pajamas");
            double A = double.Parse(Console.ReadLine());

            


            Console.WriteLine("iveskite ar taikoma 5% ar 15% pajamu mokescio norma");
            double B = double.Parse(Console.ReadLine());

            Console.WriteLine($"pajamos {A}");

            double islaidos = (A / 100) * 30;
            Console.WriteLine($"liedziamos islaidos {islaidos}");


            double pajamu = A * (B / 100);
            Console.WriteLine($"pajamu mokestis {pajamu}");

          

            double C = A - islaidos;

            double VSD = (C / 100) * 13.83;
            Console.WriteLine($"VSD {VSD}");

            double PSD = (C / 100) * 6.98;
            Console.WriteLine($"PSD {PSD}");

            double viso = pajamu + VSD + PSD;
            Console.WriteLine($"is viso mekesciu {viso}");









        }
    }
}