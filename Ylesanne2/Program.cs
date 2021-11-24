using System;
using System.IO;

namespace Ylesanne2
{
    class Program
    {
        static void Main(string[] args)
        {
            String newPath = @"C:\Users\opilane\samples\xD";
            string auto1 = $@"{newPath}\toyota.txt";
            string auto2 = $@"{newPath}\bmw.txt";
            string auto3 = $@"{newPath}\tesla.txt";

            bool directoryExists = Directory.Exists(newPath);
            bool auto1Exists = File.Exists(auto1);
            bool auto2Exists = File.Exists(auto2);
            bool auto3Exists = File.Exists(auto3);

            if (directoryExists && auto1Exists && auto2Exists && auto3Exists)
            {
                Console.WriteLine($"{auto1} on juba olemas.");
                Console.WriteLine($"{auto2} on juba olemas");
                Console.WriteLine($"{auto3} on juba olemas");
            }
            else
            {
                File.Create(auto1);
                File.Create(auto2);
                File.Create(auto3);
                Console.WriteLine($"autode txt-failid on tehtud");
            }
            Console.ReadLine();
        }
    }
}
