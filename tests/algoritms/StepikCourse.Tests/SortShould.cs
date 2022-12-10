namespace StepikCourse.Tests
{
    
    [TestFixture]
    public class SortShould
    {
        [Test]
        public void BubbleSort_GetUnsortedIntArray_ReturnsSortedIntArray()
        {
            // Arrange
            var expectedResult = new int[] { -10, -2, 0, 5, 10 };
            var unsortedInputArray = new int[] { 5, -2, 10, -10, 0 };

            // Act
            var actualResult = Sort.BubbleSort(unsortedInputArray,out int cpuOperations);
            Console.WriteLine($"cpuOperations: {cpuOperations}");

            // Assert
            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }
    }

    public class TestHelpers
    {
        public static int[] CreateIntArray(int capacity, bool isRandomFill, bool isSorted)
        {
            var array = new int[capacity];

            if (isRandomFill)
            {
                var randomInt = new Random();

                for (int i = 0; i < array.Length - 1; i++)
                {
                    array[i] = randomInt.Next(int.MinValue, int.MaxValue);
                }
            }
            else
            {
                var staticInt = 0;

                for (int i = 0; i < array.Length - 1; i++)
                {
                    array[i] = staticInt;
                }
            }

            if (isSorted)
            {
                array = Sort.BubbleSort(array);
            }
         
            return array;
        }
    }

}