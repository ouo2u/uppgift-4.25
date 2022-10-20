using System;

namespace uppgift_4._25
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("skriv ett hel tal");
            float heltal = float.Parse(Console.ReadLine());
            Console.WriteLine("skriv ett annat hel tal");
            float andraheltal = float.Parse(Console.ReadLine());
            Console.WriteLine("Välj ett av följande alternativ.");
            Console.WriteLine("1. Subtrahera ett tal med ett annat");
            Console.WriteLine("2.Dividera ett tal med ett annat");
            Console.WriteLine("3.Avsluta programmet");
            string alterntiv = Console.ReadLine();

            switch (alterntiv)
            {
                case "1":
                    Console.WriteLine("subtriktionen bli" + (heltal - andraheltal));
                    break;
                case "2":
                    Console.WriteLine("divsion blir " + (heltal / andraheltal));
                    break;
                case "3":
                    Console.WriteLine("programmet avslutats");
                    break;
            }
        }
    }
}
