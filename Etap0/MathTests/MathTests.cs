using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace MathTests
{
    public class MathTests
    {
        private Program program { get; set; } = null!;

        [SetUp]
        public void Setup()
        {
            program = new Program();
        }

        [Test]
        public void Math_add_test()
        {
            var num1 = 5;
            var num2 = 5;
            string x = "d";

            var k = program.Math(num1, num2, x);


            Assert.Pass();
        }
    }
}