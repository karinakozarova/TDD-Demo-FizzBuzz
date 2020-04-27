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
            Assert.AreEqual("1", fizzBuzz.ProcessNumber(1));
            Assert.AreEqual("2", fizzBuzz.ProcessNumber(2));
            Assert.AreEqual("4", fizzBuzz.ProcessNumber(4));
        }
        
        [TestMethod]
        public void ShouldProcessANumberDivisibleBy3()
        {
            FizzBuzz fizzBuzz = new FizzBuzz();
            String output = fizzBuzz.ProcessNumber(3);
            Assert.AreEqual("Fizz", output);
        }   
        
        [TestMethod]
        public void ShouldProcessANumberDivisibleBy5()
        {
            FizzBuzz fizzBuzz = new FizzBuzz();
            Assert.AreEqual("Buzz", fizzBuzz.ProcessNumber(5));
            Assert.AreEqual("Buzz", fizzBuzz.ProcessNumber(10));
        }


        [TestMethod]
        public void ShouldProcessANumberDivisibleBy5And3()
        {
            FizzBuzz fizzBuzz = new FizzBuzz();
            Assert.AreEqual("FizzBuzz", fizzBuzz.ProcessNumber(15));
            Assert.AreEqual("FizzBuzz", fizzBuzz.ProcessNumber(30));
        }
    }
}
