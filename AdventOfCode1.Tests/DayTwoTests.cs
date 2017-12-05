using DayTwo;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode.Tests
{
    [TestFixture]
    public class DayTwoTests
    {
        [Test]
        public void TestChecksum()
        {
            var sut = new ChecksumChecker();

            List<int[]> list = new List<int[]>()
            {
                new int[]{5,1,9,5},
                new int[]{7,5,3},
                new int[]{2,4,6,8}
            };

            var result = sut.CalculateChecksum(list);
            Assert.AreEqual(18, result);
        }

        [Test]
        public void TestChecksumDivision()
        {
            var sut = new ChecksumChecker();

            List<int[]> list = new List<int[]>()
            {
                new int[]{5,9,2,8},
                new int[]{9,4,7,3},
                new int[]{3,8,6,5}
            };

            var result = sut.CalculateDivisible(list);
            Assert.AreEqual(9, result);
        }
    }
}
