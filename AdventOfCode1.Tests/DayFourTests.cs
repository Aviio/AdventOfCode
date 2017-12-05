using DayFour;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode.Tests
{
    [TestFixture]
    public class DayThreeTests
    {
        [TestCase("aa bb cc dd ee", true)]
        [TestCase("aa bb cc dd aa", false)]
        [TestCase("aa bb cc dd aaa", true)]
        public void TestValidation(string input, bool expectedResult)
        {
            var sut = new PasswordValidator();
            var result = sut.Validate(input);
            Assert.AreEqual(expectedResult, result);
        }

        [TestCase("abcde fghij", true)]
        [TestCase("abcde xyz ecdab", false)]
        [TestCase("a ab abc abd abf abj", true)]
        [TestCase("oiii ioii iioi iiio", false)]
        [TestCase("iiii oiii ooii oooi oooo", true)]
        public void TestAnagramValidation(string input, bool expectedResult)
        {
            var sut = new PasswordValidator();
            var result = sut.ValidateAnagram(input);
            Assert.AreEqual(expectedResult, result);
        }
    }
}
