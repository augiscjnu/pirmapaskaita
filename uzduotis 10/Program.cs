using System;
using System.Diagnostics.CodeAnalysis;

namespace uzduotis10
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("iveskite valandini darbo uzmokesti");
            double uzmokestis = double.Parse(Console.ReadLine());

            Console.WriteLine("iveskite dirbtu valandu skaiciu per savaite");
            int laikas = int.Parse(Console.ReadLine());

            double sav = uzmokestis * laikas;
            Console.WriteLine($"savaitinis darbo uzmokestis {sav}");

            double men = sav * 4;
            Console.WriteLine($"menesinis darbo uzmokestis {men}");

            double metai = men * 12;
            Console.WriteLine($"metinis darbo uzmokestis {metai}");






        }
    }
}