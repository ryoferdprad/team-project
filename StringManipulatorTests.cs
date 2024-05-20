using NUnit.Framework;
using StringManipulationLib;

namespace StringManipulationTests
{
    public class StringManipulatorTests
    {
        [Test]
        public void ReverseString_ValidInput_ReturnsReversedString()
        {
            // Arrange
            string input = "Hello";

            // Act
            string reversed = StringManipulator.ReverseString(input);

            // Assert
            Assert.AreEqual("olleH", reversed);
        }

        [Test]
        public void ReverseString_EmptyString_ReturnsEmptyString()
        {
            // Arrange
            string input = "";

            // Act
            string reversed = StringManipulator.ReverseString(input);

            // Assert
            Assert.AreEqual("", reversed);
        }

        [Test]
        public void ReverseString_NullInput_ReturnsNull()
        {
            // Arrange
            string input = null;

            // Act
            string reversed = StringManipulator.ReverseString(input);

            // Assert
            Assert.IsNull(reversed);
        }
    }
}
