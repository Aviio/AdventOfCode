using System;
using System.Collections.Generic;
using System.Linq;

namespace DaySix
{
    public class MemoryBank
    {
        public int FindCollision(int[] input)
        {
            bool solved = false;
            var history = new List<int[]> { (int[])input.Clone() };
            while (!solved)
            {
                var startValue = input.Max();
                var startIndex = Array.IndexOf(input, startValue);
                input[startIndex] = 0;

                if (startIndex == input.Length)
                {
                    startIndex = 0;
                }

                for (var i = (startIndex + 1 > input.Length - 1 ? 0 : startIndex + 1); startValue > 0; i++)
                {
                    input[i]++;
                    startValue--;

                    if (i == input.Length - 1)
                    {
                        i = -1;
                    }
                }

                solved = history.Any(a => a.SequenceEqual(input));
                if (!solved) history.Add((int[])input.Clone());
            }
            return history.Count();
        }
    }
}