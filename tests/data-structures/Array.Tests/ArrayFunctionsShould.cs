using CustomArray;

namespace CustomArray
{

    public class ArrayFunctionsShould
    {

        [Test]
        [TestCase(new [] { 0 }, 0)]
        [TestCase(new [] { 1 }, 1)]
        [TestCase(new [] { 0, 0, 0, 0, 0, 0 }, 0)]
        [TestCase(new [] { 1, 1, 1, 1, 1, 1 }, 6)]
        [TestCase( new [] { 1, 1, 0, 1, 1, 1 }, 3)]
        [TestCase(new [] { 1, 0, 1, 1, 0, 1 }, 2)]
        public void FindMaxConsecutiveOnes_GetBinaryArray_ReturnsMaxConsecutiveOnesNumber(int[] testCaseArr, int expectedResult)
        {
            // Arrange

            
            // Act
            var actualResult = ArrayFunctions.FindMaxConsecutiveOnes(testCaseArr);

            // Assert

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        [TestCase(new [] { 0 }, new [] { 0 })]
        [TestCase(new [] { -1, -1, -1, -1, -1 }, new [] {-1, -2, -3, -4, -5})]
        [TestCase(new [] { 1, 2, 3, 4 }, new [] { 1, 3, 6, 10 })]
        [TestCase(new [] { 1, 1, 1, 1, 1 }, new [] { 1, 2, 3, 4, 5 })]
        [TestCase(new [] { 3, 1, 2, 10, 1 }, new [] { 3, 4, 6, 16, 17 })]
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
                new TestCaseData(new [] { new [] { 1, 2 }, new [] { 1, 2, 3 }, new [] { 1, 2, 3, 4, 5 }}, 15),
                new TestCaseData(new [] { new [] { 1, 2, 3 }, new [] { 3, 2, 1 } }, 6),
                new TestCaseData(new [] { new [] { 1, 5 }, new [] { 7, 3 }, new [] { 3, 5 } }, 10),
                new TestCaseData(new [] { new [] { 2, 8, 7 }, new [] { 7, 1, 3 }, new [] { 1, 9, 5 } }, 17),
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
        [TestCase(new [] { 1, 2, 3 }, new [] { 1, 2, 3 })]
        [TestCase(new [] { 0, 2, 3, 4 }, new [] { 0, 0, 2, 3 })]
        [TestCase(new [] { 1, 1, 1, 0 }, new [] { 1, 1, 1, 0 })]
        [TestCase(new [] { 1, 0, 2, 3, 0, 4, 5, 0 }, new [] { 1, 0, 0, 2, 3, 0, 0, 4 })]
        [Category("ShifsInArray" )]
        public void DuplicateZeros_GetIntArray_DuplicateEachZeroUntilTheArrayEnds(int[] testCaseArr, int[] expectedResult)
        {
            // Arrange

            // Act
            ArrayFunctions.DuplicateZeros(testCaseArr);

            // Assert

            Assert.That(testCaseArr, Is.EqualTo(expectedResult));
        }

        [Test]
        [TestCase(new [] { 1 }, 1, new int[] {}, 0, new [] { 1 })]
        [TestCase(new [] { 0 }, 0, new [] { 1 }, 1, new [] { 1 })]
        [TestCase(new [] { 2, 0 }, 1, new [] { 1 }, 1, new [] { 1, 2 })]
        [TestCase(new [] { 1, 2, 3, 0, 0, 0 }, 3, new [] { 2, 5, 6 }, 3, new [] { 1, 2, 2, 3, 5, 6 })]
        [Category("ArrayMerge")]
        public void Merge_GetTwoArrays_ReturnsFillAndSortedFirstArray(int[] testCaseFirstArr, int firstArrCount, int[] testCaseSecondArr, int secondArrCount, int[] expectedResult)
        {

            // Arrange
            
            // Act
            ArrayFunctions.Merge(testCaseFirstArr, firstArrCount, testCaseSecondArr, secondArrCount);

            // Assert
            Assert.That(testCaseFirstArr, Is.EqualTo(expectedResult));
        }

        [Test]
        [TestCase(new [] { 1 }, 1, 0, new [] { 1 })]
        [TestCase(new [] { 3, 2, 2, 3 }, 3, 2, new [] { 2, 2, 3, 3 })]
        [TestCase(new [] { 0, 1, 2, 2, 3, 0, 4, 2 }, 2, 5, new [] { 0, 1, 4, 0, 3, 2, 2, 2 })]
        [Category("DeleteFromArray")]
        public void RemoveElement_GetArrayAndValue_ReturnsCountOfExistedElementsAndMovedAllFoundedElemAtTheEnd(int[] testCaseArr, int valueForDelete, int expectedFinalLength, int[] expectedArrayAfterDelete)
        {
            // Arrange

            // Act
            var actualFinalLength = ArrayFunctions.RemoveElement(testCaseArr, valueForDelete);

            // Assert
            Assert.That(testCaseArr, Is.EqualTo(expectedArrayAfterDelete));
            Assert.That(expectedFinalLength, Is.EqualTo(actualFinalLength));
        }

        [Test]
        [TestCase(new [] { 1, 1, 2 }, 2, new [] { 1, 2, 1 })]
        [TestCase(new [] { 1, 2, 3 }, 3, new [] { 1, 2, 3 })]
        [TestCase(new [] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 }, 5, new [] { 0, 1, 2, 3, 4, 0, 1, 1, 2, 3 })]
        [Category("DeleteFromArray")]
        public void RemoveDuplicates_GetArrayWithDublicates_ReturnsCountOfExistedElementsAndMovedDuplicatesToTheEnd(int[] testCaseArr, int expectedFinalLength, int[] expectedArrayAfterDelete)
        {
            // Arrange

            // Act
            var actualFinalLength = ArrayFunctions.RemoveDuplicates(testCaseArr);

            // Assert
            Assert.That(expectedFinalLength, Is.EqualTo(actualFinalLength));
        }

        [Test]
        [TestCase(new[] { 0, 0 }, true)]
        [TestCase(new[] { 0, 0, 0, 0 }, true)]
        [TestCase(new[] { 7, 1, 14, 11 }, true)]
        [TestCase(new [] { 10, 2, 5, 3 }, true)]
        [TestCase(new [] { 3, 1, 7, 11 }, false)]
        [TestCase(new[] { -2, 0, 10, -19, 4, 6, -8 }, false)]
        [Category("SearchInArray")]
        public void CheckIfValueAndItsDoubleExistIn_HashSetVersion_GetUnsortedArray_ReturnsIsExistFlag(int[] testCaseArr, bool expectedIsExist)
        {

            // Arrange
            
            // Act
            var actualIsExist = ArrayFunctions.CheckIfValueAndItsDoubleExistIn_HashSetVersion(testCaseArr);

            // Assert
            Assert.That(actualIsExist, Is.EqualTo(expectedIsExist));
        }

        [Test]
        [TestCase(new[] { 0, 0 }, true)]
        [TestCase(new[] { 0, 0, 0, 0 }, true)]
        [TestCase(new[] { 7, 1, 14, 11 }, true)]
        [TestCase(new[] { 10, 2, 5, 3 }, true)]
        [TestCase(new[] { 3, 1, 7, 11 }, false)]
        [TestCase(new[] { -2, 0, 10, -19, 4, 6, -8 }, false)]
        [Category("SearchInArray")]
        public void CheckIfValueAndItsDoubleExistIn_BinarySearchVersion_GetUnsortedArray_ReturnsIsExistFlag(int[] testCaseArr, bool expectedIsExist)
        {
            // Arrange
            
            // Act
            var actualIsExist = ArrayFunctions.CheckIfValueAndItsDoubleExistIn_BinarySearchVersion(testCaseArr);

            // Assert
            Assert.That(actualIsExist, Is.EqualTo(expectedIsExist));
        }
    }
}