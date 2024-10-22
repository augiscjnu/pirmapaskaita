using System;

namespace auzduotis2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("iveskite nuvaziuta atstuma (km): ");
            double atsumas = double.Parse(Console.ReadLine());

            Console.WriteLine("iveskite kuro kieki (l): ");
            double kuras = double.Parse(Console.ReadLine());

            double kurosanaudos = atsumas / kuras;
            Console.WriteLine($"kuro sanaudos 100 km {kurosanaudos}");
        }
    }
}