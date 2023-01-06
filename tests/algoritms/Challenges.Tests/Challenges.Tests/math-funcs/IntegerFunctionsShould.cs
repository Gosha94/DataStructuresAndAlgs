using Challenges.math_funcs;

namespace math_funcs
{

    public class IntegerFunctionsShould
    {

        [Theory]
        [Trait("Category", "math-funcs")]
        [InlineData(0, 1)]
        [InlineData(2, 3)]
        [InlineData(102, 333)]
        [InlineData(123, 400)]
        [InlineData(857, 900)]
        [InlineData(901, 2222)]
        [InlineData(958, 1000)]
        [InlineData(999, 1000)]
        [InlineData(777, 800)]
        [InlineData(3025, 4111)]
        [InlineData(654321, 700000)]
        public void GetNextClosestTo_ReceiveIntValue_ReturnsClosestValueToInput(int testCaseValue, int expectedValue)
        {

            // Arrange

            // Act
            var actualValue = IntegerFunctions.GetNextClosestTo(testCaseValue);
            
            // Assert
            Assert.Equal(expectedValue, actualValue);
        }

        [Theory]
        [InlineData(0, 1)]
        [InlineData(2, 3)]
        [InlineData(102, 333)]
        [InlineData(123, 400)]
        [InlineData(857, 900)]
        [InlineData(901, 2222)]
        [InlineData(958, 1000)]
        [InlineData(999, 1000)]
        [InlineData(777, 800)]
        [InlineData(3025, 4111)]
        [InlineData(654321, 700000)]
        public void GetNextClosestTo_V2_ReceiveIntValue_ReturnsClosestValueToInput(int testCaseValue, int expectedValue)
        {

            // Arrange

            // Act
            var actualValue = IntegerFunctions.GetNextClosestTo_V2(testCaseValue);

            // Assert
            Assert.Equal(expectedValue, actualValue);
        }

        [Theory]
        [InlineData(0, 0)]
        [InlineData(1, 1)]
        [InlineData(8, 4)]
        [InlineData(14, 6)]
        public void GetReducingStepsToZero_ReceiveIntNumber_ReturnsCorrectOperationsNumber(int testCaseValue, int expectedValue)
        {
            // Arrange

            // Act
            var actualValue = IntegerFunctions.GetReducingStepsToZero(testCaseValue);

            // Assert
            Assert.Equal(expectedValue, actualValue);
        }

    }
}