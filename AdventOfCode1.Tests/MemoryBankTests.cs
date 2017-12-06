
using DaySix;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode.Tests
{
    [TestFixture]
    public class MemoryBankTests
    {
        [TestCase(new int[] { 0, 2, 7, 0 }, 5)]
        public void TestFindCollission(int[] input, int expectedCycles)
        {
            var sut = new MemoryBank();
            var result = sut.FindCollision(input);
            Assert.AreEqual(expectedCycles, result);

        }
    }
}
