using System;
using System.IO;

namespace createtitpe
{
    class Program
    {
        static void Main(string[] args)
        {
            string newPath = @"C:\Users\opilane\samples\";
            Console.WriteLine("sisesta kausta nimi");
            string kaust = Console.ReadLine();

            string newdirectory = $@"{newPath}\{kaust}";


            bool directoryExists = Directory.Exists(newdirectory);

            if (directoryExists)
            {
                Console.WriteLine($"{kaust} already exists in samples");
            }
            else
            {

                Directory.CreateDirectory(newdirectory);
                Console.WriteLine($"directory {kaust} has been created");
            }
            Console.ReadLine();




        }
    }
}