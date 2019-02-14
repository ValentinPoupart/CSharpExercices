using ExamFA.Impl;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExamFA.Tests
{
    [TestClass]
    public class FizzBuzzTests
    {
        // If a number is a multiple of 3 => Fizz
        // If a number is a multiple of 5 => Buzz
        // If a number is a multiple of 3 and 5 => FizzBuzz
        // Empty string otherwise
        [TestMethod]
        public void ShouldReturnFizz_When_InputIsMultipleOf3()
        {
            // Arrange
            var subject = new FizzBuzz();

            // Act
            var output1 = subject.Analyze(3);
            var output2 = subject.Analyze(6);
            var output3 = subject.Analyze(18);

            // Assert
            Assert.AreEqual("Fizz", output1);
            Assert.AreEqual("Fizz", output2);
            Assert.AreEqual("Fizz", output3);
        }

        [TestMethod]
        public void ShouldReturnBuzz_When_InputIsMultipleOf5()
        {
            // Arrange
            var subject = new FizzBuzz();

            // Act
            var output1 = subject.Analyze(5);
            var output2 = subject.Analyze(10);
            var output3 = subject.Analyze(20);

            // Assert
            Assert.AreEqual("Buzz", output1);
            Assert.AreEqual("Buzz", output2);
            Assert.AreEqual("Buzz", output3);
        }

        [TestMethod]
        public void ShouldReturnFizzBuzz_When_InputIsMultipleOf3And5()
        {
            // Arrange
            var subject = new FizzBuzz();

            // Act
            var output1 = subject.Analyze(15);
            var output2 = subject.Analyze(30);
            var output3 = subject.Analyze(60);

            // Assert
            Assert.AreEqual("FizzBuzz", output1);
            Assert.AreEqual("FizzBuzz", output2);
            Assert.AreEqual("FizzBuzz", output3);
        }

        [TestMethod]
        public void ShouldReturnEmpty_When_InputIsNotMultipleOf3And5()
        {
            // Arrange
            var subject = new FizzBuzz();

            // Act
            var output1 = subject.Analyze(1);
            var output2 = subject.Analyze(2);
            var output3 = subject.Analyze(4);

            // Assert
            Assert.AreEqual(string.Empty, output1);
            Assert.AreEqual(string.Empty, output2);
            Assert.AreEqual(string.Empty, output3);
        }
    }
}
