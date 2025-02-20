using Xunit;

namespace Indigo.Core.PackageTest
{
    public class CustomConvertTest
    {
        [Fact]
        public void AsString_WithStringValue_ReturnsSameString()
        {
            // Arrange
            object value = "test string";

            // Act
            string result = value.AsString();

            // Assert
            Assert.Equal("test string", result);
        }

        [Fact]
        public void AsString_WithIntValue_ReturnsStringRepresentation()
        {
            // Arrange
            object value = 123;

            // Act
            string result = value.AsString();

            // Assert
            Assert.Equal("123", result);
        }

        [Fact]
        public void AsString_WithNullValue_ThrowsNullReferenceException()
        {
            // Arrange
            object value = null;

            // Act & Assert
            Assert.Throws<NullReferenceException>(() => value.AsString());
        }

        [Fact]
        public void AsString_WithDoubleValue_ReturnsStringRepresentation()
        {
            // Arrange
            object value = 123.45;

            // Act
            string result = value.AsString();

            // Assert
            Assert.Equal("123,45", result);
        }
    }
}