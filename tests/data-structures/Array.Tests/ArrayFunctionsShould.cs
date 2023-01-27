using CustomArray;

namespace CustomArray
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

        [Test]
        [TestCase(new int[] { 0 }, new int[] { 0 })]
        [TestCase(new int[] { -1, -1, -1, -1, -1 }, new int[] {-1, -2, -3, -4, -5})]
        [TestCase(new int[] { 1, 2, 3, 4 }, new int[] { 1, 3, 6, 10 })]
        [TestCase(new int[] { 1, 1, 1, 1, 1 }, new int[] { 1, 2, 3, 4, 5 })]
        [TestCase(new int[] { 3, 1, 2, 10, 1 }, new int[] { 3, 4, 6, 16, 17 })]
        public void GetEachElementSum_GetIntArray_ReturnsCorrectArrayOfEachElementSum(int[] testCaseArr, int[] expectedResult)
        {
            // Arrange

            // Act
            var actualResult = ArrayFunctions.GetEachElementSum(testCaseArr);

            // Assert

            Assert.AreEqual(expectedResult, actualResult);
        }

        public static IEnumerable<TestCaseData> combination_tests()
        {

            var testCases = new List<TestCaseData>()
            {
                new TestCaseData(new int[][] { new int[] { 1, 2 }, new int[] { 1, 2, 3 }, new int[] { 1, 2, 3, 4, 5 }}, 15),
                new TestCaseData(new int[][] { new int[] { 1, 2, 3 }, new int[] { 3, 2, 1 } }, 6),
                new TestCaseData(new int[][] { new int[] { 1, 5 }, new int[] { 7, 3 }, new int[] { 3, 5 } }, 10),
                new TestCaseData(new int[][] { new int[] { 2, 8, 7 }, new int[] { 7, 1, 3 }, new int[] { 1, 9, 5 } }, 17),
            };

            return testCases;
        }

        [Test]
        [Category("2D Arrays")]
        [TestCaseSource(nameof(combination_tests))]
        public void GetMaxRowSum_Get2DIntArray_ReturnsCorrectMaxRowSum(int[][] testCaseArr, int expectedResult)
        {
            // Arrange


            // Act
            var actualResult = ArrayFunctions.GetMaxRowSum(testCaseArr);

            // Assert

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        [TestCase(new int[] { 1, 2, 3 }, new int[] { 1, 2, 3 })]
        [TestCase(new int[] { 0, 2, 3, 4 }, new int[] { 0, 0, 2, 3 })]
        [TestCase(new int[] { 1, 1, 1, 0 }, new int[] { 1, 1, 1, 0 })]
        [TestCase(new int[] { 1, 0, 2, 3, 0, 4, 5, 0 }, new int[] { 1, 0, 0, 2, 3, 0, 0, 4 })]
        [Category("ArrayShifting" )]
        public void DuplicateZeros_GetIntArray_DuplicateEachZeroUntilTheArrayEnds(int[] testCaseArr, int[] expectedResult)
        {
            // Arrange

            // Act
            ArrayFunctions.DuplicateZeros(testCaseArr);

            // Assert

            Assert.That(testCaseArr, Is.EqualTo(expectedResult));
        }
        

    }
}