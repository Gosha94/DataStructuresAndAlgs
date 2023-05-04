using Challenges.math_funcs;
namespace Challenges.Tests.math_funcs;

public class BigNumberShould
{
    [Theory]
    [Trait("Category", "math_funcs")]
    [InlineData("123456", "123456")]
    [InlineData("123456123456123456123456123456123456123456", "123456123456123456123456123456123456123456")]
    public void GetCorrectNumberAsString_PerformValidConstructionAndSerialization(string testCaseNum, string expectedResult)
    {
        // Arrange

        // Act
        var actualResult = new BigNumber(testCaseNum).ToString();

        // Assert
        Assert.Equal(expectedResult, actualResult);
    }

    [Theory]
    [Trait("Category", "math_funcs")]
    [InlineData("1", "2", "3")]
    [InlineData("100", "200", "300")]
    [InlineData("700", "800", "1500")]
    [InlineData("123000", "456", "123456")]
    [InlineData("456", "123000", "123456")]
    [InlineData("999999", "1", "1000000")]
    [InlineData("1", "999999", "1000000")]
    [InlineData("3", "99", "102")]
    [InlineData("1111111111111111111111111111111111111111", "2222222222222222222222222222222222222222", "3333333333333333333333333333333333333333")]
    [InlineData("918", "726", "1644")]
    [InlineData("918000000", "726000000", "1644000000")]
    [InlineData("50000000000", "40000000000", "90000000000")]
    [InlineData("123456789987654321", "100000000100000000", "223456790087654321")]
    [InlineData("1234567891234567891230", "1", "1234567891234567891231")]
    [InlineData("500000000000000000000", "400000000000000000000", "900000000000000000000")]
    [InlineData("5000000000", "4900000000", "9900000000")]
    [InlineData("11", "99", "110")]
    [InlineData("99", "11", "110")]
    public void GetTwoNumberAsString_CorrectPerformAddMathOperation(string number1, string number2, string expectedResult)
    {
        // Arrange
        var bNumber1 = new BigNumber(number1);
        var bNumber2 = new BigNumber(number2);

        // Act
        var sum = bNumber1 + bNumber2;

        // Assert
        Assert.Equal(expectedResult, sum.ToString());
    }

    [Theory]
    [Trait("Category", "math_funcs")]
    [InlineData("998", "12")]
    public void AfterAddOperation_SupportsImmutabilityOfOperators(string number1, string number2)
    {
        // Arrange
        var bNumber1 = new BigNumber(number1);
        var bNumber2 = new BigNumber(number2);

        // Act
        var bNumber3 = bNumber1 + bNumber2;

        // Assert
        Assert.Equal(number1, bNumber1.ToString());
        Assert.Equal(number2, bNumber2.ToString());        
    }

    [Fact]
    [Trait("Category", "math_funcs")]
    public void KeepArgumentImmutable_AfterToStringMethodCall()
    {
        // Arrange
        var number = "12345678910";

        // Act
        var bNumber = new BigNumber(number);

        // Assert
        Assert.Equal(number, bNumber.ToString());
    }
}