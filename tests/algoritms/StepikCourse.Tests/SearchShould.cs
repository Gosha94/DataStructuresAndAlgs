namespace StepikCourse.Tests
{

    [TestFixture]
    public class SearchShould
    {
        [Test]
        public void BinarySearch_GetSortedIntArrayAndNumberForFind_ReturnsIndexOfFoundedElement()
        {
            // Arrange
            var inputArr = new int[] { 10, 11, 12, 13, 14, 15 };
            var cpuOperations = 0;
            var expectedResult = 0;

            // Act
            var actualResult = Search.BinarySearch(inputArr, 10, out cpuOperations);
            Console.WriteLine($"cpuOperations: {cpuOperations}");

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

    }
}