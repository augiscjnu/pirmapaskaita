using System;

namespace PirmaPaskaita1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int a = 9;
            int b = 5;
            int suma = a - b;

            Console.WriteLine(suma);

            string vardas = "Sarunas";
            string pavarde;

            pavarde = Console.ReadLine();

            Console.WriteLine("Cia dirba " + vardas + " " + pavarde);

            char raide = 't';

            raide = char.Parse(Console.ReadLine());

            Console.WriteLine("Iveskite pirma skaiciu: ");
            int skaiciusIsKonsoles1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Iveskite antra skaiciu: ");
            int skaiciusIsKonsoles2 = int.Parse(Console.ReadLine());

            Console.Write("Sandauga: ");
            Console.Write(skaiciusIsKonsoles1 * skaiciusIsKonsoles2);

        }
    }
}