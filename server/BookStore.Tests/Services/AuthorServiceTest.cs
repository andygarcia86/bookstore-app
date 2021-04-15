using FluentAssertions;
using Xunit;

namespace BookStore.Tests.Services
{
    public class AuthorServiceTest
    {
        [Fact]
        public void TestMethod()
        {
            // Arrange
            var expected = "Hello";

            // Act
            var actual = "Hello";

            // Assert
            actual.Should().Be(expected);
        }
    }
}
