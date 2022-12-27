﻿using Challenges.math_funcs;

namespace Challenges.Tests
{

    public class IntegerFunctionsShould
    {

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
        
        public void GetNextClosestTo_ReceiveIntValue_ReturnsClosestValueToInput(int testCaseValue, int expectedValue)
        {

            // Arrange

            // Act
            var actualValue = IntegerFunctions.GetNextClosestTo(testCaseValue);

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

            Assert.Equal(expectedValue, actualValue);
        }
    }
}