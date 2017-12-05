using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text.RegularExpressions;

namespace DayTwo.Harness
{
    class Program
    {
        private static ChecksumChecker _checksumChecker = new ChecksumChecker();
        static void Main(string[] args)
        {
            Console.WriteLine("Day 2 Harness!");
            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = "DayTwo.Harness.day2.txt";
            List<int[]> checksum = new List<int[]>();

            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            using (StreamReader reader = new StreamReader(stream))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(Regex.Replace(line, @"\s+", ""));
                    checksum.Add(Array.ConvertAll(Regex.Replace(line, @"\s+", " ").Split(), c => (int)int.Parse(c)));
                }
               
            }
            Console.Write("Answer Part 1: ");
            Console.WriteLine(_checksumChecker.CalculateChecksum(checksum));
            Console.Write("Answer Part 2: ");
            Console.WriteLine(_checksumChecker.CalculateDivisible(checksum));

            Console.ReadKey();
        }
    }
}
