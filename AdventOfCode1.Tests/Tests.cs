using NUnit.Framework;
using System;

namespace AdventOfCode1.Tests
{
    [TestFixture]
    public class Tests
    {
        [TestCase("1122", "3", false)]
        [TestCase("1111", "4", false)]
        [TestCase("1234", "0", false)]
        [TestCase("91212129", "9", false)]
        [TestCase("1212", "6", true)]
        [TestCase("1221", "0", true)]
        [TestCase("123425", "4", true)]
        [TestCase("123123", "12", true)]
        [TestCase("12131415", "4", true)]
        public void TestCaptcha(string captcha, string result, bool isPt2)
        {
            //arrange
            var captchaSolver = new CaptchaSolver();
            //act
            var captchaResult = captchaSolver.SolveCatpcha(captcha, isPt2);
            //assert
            Assert.AreEqual(result, captchaResult);
        
        }





    }
}
