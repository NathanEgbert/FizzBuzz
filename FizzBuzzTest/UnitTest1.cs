using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzzClass;
namespace FizzBuzzTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //arrange
            var FizzBuzz = new FizzBuzz();

            //act
            var result = FizzBuzz.evaluate(15);

            //assert
            Assert.AreEqual(result, "FizzBuzz");
        }

        [TestMethod]
        public void TestMethod2()
        {
            //arrange
            var FizzBuzz = new FizzBuzz();

            //act
            var result = FizzBuzz.evaluate(3);

            //assert
            Assert.AreEqual(result, "Fizz");
        }

        [TestMethod]
        public void TestMethod3()
        {
            //arrange
            var FizzBuzz = new FizzBuzz();

            //act
            var result = FizzBuzz.evaluate(5);

            //assert
            Assert.AreEqual(result, "Buzz");
        }
    }
}
