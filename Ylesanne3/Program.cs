using System;
using System.Collections.Generic;
using System.IO;

namespace Ylesanne3
{
    class Program
    {
        static void Main(string[] args)
        {
            string Toyota = @"C:\Users\opilane\samples\xD\toyota.txt";
            string BMW = @"C:\Users\opilane\samples\xD\bmw.txt";
            string Tesla = @"C:\Users\opilane\samples\xD\tesla.txt";
            string Cars = @"C:\Users\opilane\samples\xD\cars.txt";

            List<string> toyota = new List<string>();
            List<string> bmw = new List<string>();
            List<string> tesla = new List<string>();

            string[] sourceData = File.ReadAllLines(Cars);

            foreach (string element in sourceData)
            {
                if (element.Contains("Toyota"))
                {
                    toyota.Add(element);
                }
                if (element.Contains("BMW"))
                {
                    bmw.Add(element);
                }
                if (element.Contains("Tesla"))
                {
                    tesla.Add(element);
                }

                File.WriteAllLines(Toyota, toyota);
                File.WriteAllLines(BMW, bmw);
                File.WriteAllLines(Tesla, tesla);
            }

        }
    }
}
