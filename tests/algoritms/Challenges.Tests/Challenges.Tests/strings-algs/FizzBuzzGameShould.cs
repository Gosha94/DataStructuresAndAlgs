using Challenges.strings_algs;

namespace strings_algs;

public class FizzBuzzGameShould
{

    public static IEnumerable<object[]> TestCasesGenerator()
    {
        yield return new object[] { 3 , new List<string> { "1", "2", "Fizz" } };
        yield return new object[] { 5, new List<string> { "1", "2", "Fizz", "4", "Buzz" } };
        yield return new object[] { 15, new List<string> { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz" } };
    }

    [Theory]
    [Trait("Category", "strings-algs")]
    [MemberData(nameof(TestCasesGenerator))]
    public void PlayFizzBuzz_GetNumberOfTurns_ReturnsCorrectAnswers(int testCaseTurnsNum, List<string> expectedValue)
    {
        // Arrange

        // Act
        var actualValue = FizzBuzzGame.PlayFizzBuzz(testCaseTurnsNum );

        // Assert
        Assert.Equal(expectedValue, actualValue);
    }
}