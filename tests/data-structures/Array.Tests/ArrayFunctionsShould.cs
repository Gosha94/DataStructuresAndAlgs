namespace Array.Tests
{
    public class ArrayFunctionsShould
    {

        [Test]
        [TestCase(new int[] { 0 }, 0)]
        [TestCase(new int[] { 1 }, 1)]
        [TestCase(new int[] { 0, 0, 0, 0, 0, 0 }, 0)]
        [TestCase(new int[] { 1, 1, 1, 1, 1, 1 }, 6)]
        [TestCase( new int[] { 1, 1, 0, 1, 1, 1 }, 3)]
        [TestCase(new int[] { 1, 0, 1, 1, 0, 1 }, 2)]
        public void FindMaxConsecutiveOnes_GetBinaryArray_ReturnsMaxConsecutiveOnesNumber(int[] testCaseArr, int expectedResult)
        {
            // Arrange

            
            // Act
            var actualResult = ArrayFunctions.FindMaxConsecutiveOnes(testCaseArr);

            // Assert

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}