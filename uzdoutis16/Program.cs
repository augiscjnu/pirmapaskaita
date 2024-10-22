using System;
using System.Diagnostics.CodeAnalysis;

namespace uzduotis16
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("iveskite bendra elektros energijos suvartojimas per menesi (kWh)");
            double A = double.Parse(s:Console.ReadLine());


            Console.WriteLine("iveskite jai taikomas papildomi mokesciai (pvz. abonementas ar kitoks fiksoutas mokestis)");
            double C = double.Parse(Console.ReadLine());


            double kaina = A * (double)double.Parse(Console.ReadLine());
            Console.WriteLine($"elektros energijos sanaudos {kaina}");

            double bendra = kaina + C;
            Console.WriteLine($"bendra suma {bendra}");







}
    }
}