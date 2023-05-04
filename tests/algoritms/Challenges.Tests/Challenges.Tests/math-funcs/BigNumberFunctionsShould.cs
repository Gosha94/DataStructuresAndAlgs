using Challenges.math_funcs;

namespace Challenges.Tests.math_funcs;

public class BigNumberFunctionsShould
{

    [Theory]
    [Trait("Category", "math_funcs")]
    [InlineData("1888abc", "1999", "")]
    [InlineData("1888", "bca1999", "")]
    [InlineData("1888", "1999", "3887")]
    [InlineData("12345", "333", "12678")]
    [InlineData("8888", "9999", "18887")]
    [InlineData("14475773473473743434342342342343", "54545454545454545454545454545454", "69021228018928288888887796887797")]
    public void SumTwoBigNumbers_GetTwoHugeStringsWithNumbers_ReturnsCorrectSumAsString(string numb1, string numb2, string expectedResult)
    {
        // Arrange
        
        // Act
        var actualResult = BigNumberFunctions.SumTwoBigNumbers(numb1, numb2);

        // Assert
        Assert.Equal(expectedResult, actualResult);
    }
}
