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
            foreach (var row in checksum)
            {
                differences.Add((row.Max() - row.Min()));
            }
            return differences.Sum();
        }

        public int CalculateDivisible(List<int[]> checksum)
        {
            List<int> differences = new List<int>();
            //surely there must be an easier way.... please
            foreach (var row in checksum)
            {
                var rowLength = row.Length - 1;
                for (var i = 0; i <= rowLength; i++)
                {
                    for (var m = 0; m <= rowLength; m++)
                    {
                        if (row[i] > row[m])
                        {
                            double divisionResult = (double)((double)row[i] / (double)row[m]);
                            //can divide
                            if (Math.Abs(divisionResult % 1) <= (Double.Epsilon * 100))
                            {
                                differences.Add((int)divisionResult);
                                break;
                            }
                        }
                    }
                }
            }
            return differences.Sum();
        }
    }
}