using NUnit.Framework;
using System;

namespace AdventOfCode1.Tests
{
    [TestFixture]
    public class Tests
    {
        [TestCase("1122", "3")]
        [TestCase("1111", "4")]
        [TestCase("1234", "0")]
        [TestCase("91212129", "9")]
        public void TestCaptcha(string captcha, string result)
        {
            //arrange
            var captchaSolver = new CaptchaSolver();
            //act
            var captchaResult = captchaSolver.SolveCatpcha(captcha);
            //assert
            Assert.AreEqual(result, captchaResult);
        
        }

    }
}
