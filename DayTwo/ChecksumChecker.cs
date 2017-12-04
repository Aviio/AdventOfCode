using System;
using System.Collections.Generic;
using System.Linq;

namespace DayTwo
{
    public class ChecksumChecker
    {
        public int CalculateChecksum(List<int[]> checksum)
        {
            List<int> differences = new List<int>();

            foreach(var row in checksum)
            {
               differences.Add((row.Max() - row.Min()));
            }

            return differences.Sum();
        }
    }
}
    