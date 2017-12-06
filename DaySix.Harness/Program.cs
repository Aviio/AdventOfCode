using System;

namespace DaySix.Harness
{
    class Program
    {
        
        static void Main(string[] args)
        {
            var memoryBank = new MemoryBank();
            Console.WriteLine("Hello World!");

            var input = new[] { 14, 0, 15, 12, 11, 11, 3, 5, 1, 6, 8, 4, 9, 1, 8, 4 };
            var cycles = memoryBank.FindCollision(input);

            Console.WriteLine($"Answer: {cycles} cycles");
            Console.ReadKey();
        }
    }
}
