using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzzTDD;

namespace FizzBuzzUnitTests
{
    [TestClass]
    public class FizzBuzzClass
    {
        [TestMethod]
        public void ShouldProcessANumber()
        {
            FizzBuzz fizzBuzz = new FizzBuzz();
            String output = fizzBuzz.ProcessNumber(1);
            Assert.AreEqual(output, "1");
        }
    }
}
