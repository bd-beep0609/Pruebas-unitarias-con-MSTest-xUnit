using Xunit;

namespace BADC.StringManipulator.UnitTestAppxUnit
{
    public class StringManipulatorTests
    {
        [Fact]
        public void ReverseString_ShouldReturnReversedString()
        {
            // Arrange
            var manipulator = new BADC.StringManipulator.StringManipulator();
            string input = "Hola Mundo";

            // Act
            string result = manipulator.ReverseString(input);

            // Assert
            Assert.Equal("odnuM aloH", result);
        }

        [Fact]
        public void RemoveSpaces_ShouldReturnStringWithoutSpaces()
        {
            // Arrange
            var manipulator = new BADC.StringManipulator.StringManipulator();
            string input = "Hola Mundo desde Linux";

            // Act
            string result = manipulator.RemoveSpaces(input);

            // Assert
            Assert.Equal("HolaMundodesdeLinux", result);
        }
    }
}