using System;
using System.IO;

namespace Ylesanne_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Random Facts So INteresting You'll Say, OMG!");
            Console.WriteLine("Mitut fakti sa tahad?");
            
            int usernumber = Convert.ToInt32(Console.ReadLine());
            GetJokes(usernumber);
        }
        private static void GetJokes(int Factnumber)
        {
            string filePath = @"C:\Users\opilane\samples\xD\funfacts.txt";
            string[] funfacts = File.ReadAllLines(filePath);

            if (Factnumber > funfacts.Length)
            {
                Factnumber = funfacts.Length;
            }

            for (int i = 0; i < Factnumber; i++)
            {
                Console.WriteLine(funfacts[i]);
            }

        }
    }
}
