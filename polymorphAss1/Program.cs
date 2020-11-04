using System;

namespace polymorphAss1
{
    class Program
    {
        static void Main(string[] args)
        {
            OvernightPackage overnightPackage = new OvernightPackage("Abuja", "Lagos", 5500M);
            TwoDaysPackage twoDaysPackage = new TwoDaysPackage("Jos", "Kaduna", 8500M);

            // Console.WriteLine($"{overnightPackage}");
            // Console.WriteLine($"{twoDaysPackage}");

            Console.WriteLine("\n Packages processed polymorphically...\n");
            Package[] packages = new Package[2] { overnightPackage, twoDaysPackage };

            foreach (Package package in packages)
            {
                Console.WriteLine($"{package}");
            }




        }
    }
}
