using System;
using System.IO;

namespace Ylesanna4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vali üks neist autodest: Toyota, BMW või Tesla");

            string car = Console.ReadLine();
            string rootPath = @"C:\Users\opilane\samples\xD";
            string fullfilePath = $@"{rootPath}\{car}.txt";

            bool exists = File.Exists(fullfilePath);

            if (exists)
            {
                string[] datafromFile = File.ReadAllLines(fullfilePath);
                if (car == "Toyota" || car == "BMW" || car == "Tesla")
                {
                    foreach (string line in datafromFile)
                    {
                        Console.WriteLine(line);
                    }

                }
                else
                {
                    Console.WriteLine($"{car}.txt file does not exist");
                }

            }
            else
            {
                Console.WriteLine($"{car}.txt file does not exist");
            }


        }
    }
}
