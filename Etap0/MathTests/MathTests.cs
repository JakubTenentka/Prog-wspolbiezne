using Microsoft.VisualStudio.TestPlatform.TestHost;
using NUnit.Framework;
using Etap0;


namespace Etap0.Tests
{
    [TestFixture]
    public class ProgramTests
    {
        [TestCase(2, 3, "a", ExpectedResult = 5)]
        [TestCase(5, 3, "s", ExpectedResult = 2)]
        [TestCase(2, 3, "m", ExpectedResult = 6)]
        [TestCase(6, 3, "d", ExpectedResult = 2)]
        public double Math_ShouldCalculateCorrectResult(double num1, double num2, string x)
        {
            // Arrange
            Program program = new Program();

            // Act
            var result = program.Calculate(num1, num2, x);

            // Assert
            return result;
        }

        [TestCase(2, 0, "d")]
        public void Math_DivideByZero_ShouldPromptForNonZeroDivisor(double num1, double num2, string x)
        {
            // Arrange
            var program = new Program();

            // Act
            TestDelegate action = () => program.Calculate(num1, num2, x);

            // Assert
            Assert.That(action, Throws.Exception.TypeOf<DivideByZeroException>());
        }
    }
}
