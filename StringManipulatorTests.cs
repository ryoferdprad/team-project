using NUnit.Framework;
using StringManipulationLib;

namespace StringManipulationLib.Tests
{
    [TestFixture]
    public class StringManipulatorTests
    {
        [Test]
        public void ReverseString_InputString_ReturnsReversedString()
        {
            // Arrange
            string input = "Hello";
            string expectedOutput = "olleH";

            // Act
            string actualOutput = StringManipulator.ReverseString(input);

            // Assert
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [Test]
        public void Analyze_InputString_ReturnsAnalysisResult()
        {
            // Arrange
            string input = "Lorem ipsum dolor sit amet";
            string expectedAnalysisResult = "Analysis:\n" +
                "- Character Count: 26\n" +
                "- Word Count: 5\n" +
                "- Reversed String:\n" +
                "tema tis rolod muspi meroL";

            // Act
            string actualAnalysisResult = StringManipulator.Analyze(input);

            // Assert
            Assert.AreEqual(expectedAnalysisResult, actualAnalysisResult);
        }
    }
}
