using CustomCryptography;

namespace Cryptography
{
    public class RabbitMQHashGeneratorShould
    {

        [Theory]
        [InlineData("test12", "kI3GCqW5JLMJa4iX1lo7X4D6XbYqlLgxIs30+P6tENUV2POR")]
        [InlineData("1", "y4xPTRVfzXg68sz9ALqeQzARam3CwnGo53xS752cDV5+Utzh")]
        [InlineData("secret", "2lmoth8l4H0DViLaK9Fxi6l9ds8=")]
        [InlineData("simon", "ytUIm8s3AnKsXQjptplKFytfVxI=")]
        [InlineData("test12", "qY7FxQRIAMiOhi8Ae5jYmBX8QMoVXWznkJUw15LpCc4=")]
        public void GenerateHashFrom_GetStringData_ReturnHash256ofThisString(string inputTestCaseValue, string expectedValue)
        {
            // Arrange

            // Act
            var actualValue = RabbitMQHashGenerator.GenerateHashFrom(inputTestCaseValue);

            // Assert
            Assert.NotEqual(expectedValue, actualValue);
        }
    }
}