using CustomLinkedList.Models;
using NUnit.Framework;

namespace CustomLinkedList.Tests
{

    [TestFixture]
    public class CustomSinglyLinkedListShould
    {

        private const int CorrectListValue = 200;
        private const int ErrorOfGettingListValue = -1;

        #region Initialize Tests

        [Test]
        [Category("Unit")]
        public void CorrectInitialize()
        {
            
            // Arrange

            // Act
            var listUnderTests = new MyLinkedList();

            // Assert
            Assert.True(listUnderTests is object && listUnderTests is MyLinkedList);
        }

        #endregion

        #region GetByIndex() Tests
        
        [Test]        
        [Category("Unit")]
        public void CorrectGetValueByIndex()
        {
            // Arrange
            var listUnderTests = new MyLinkedList();
            listUnderTests.AddAtHead(CorrectListValue);

            // Act
            var actualValueFromList = listUnderTests.Get(0);

            // Assert
            Assert.AreEqual(actualValueFromList, CorrectListValue);
        }

        [Test]
        [Category("Unit")]
        public void ReturnsErrorOfGetIfIndexIsInvalid()
        {

            // Arrange
            var listUnderTests = new MyLinkedList();

            // Act
            var actualValueFromList = listUnderTests.Get(1);

            // Assert
            Assert.AreEqual(actualValueFromList, ErrorOfGettingListValue);
        }

        #endregion

        #region AddAtHead() Tests

        [Test]
        [TestCase(new [] { 999 })]
        [Category("Unit")]
        public void CorrectAddValueAtHead(int[] arrayForInsert)
        {
            // Arrange            
            var expectedValueInHead = arrayForInsert[0];
            var linkedListUnderTests = new MyLinkedList();

            // Act
            linkedListUnderTests.AddAtHead(arrayForInsert[0]);

            var actualValueInHead = linkedListUnderTests.Get(0);

            // Assert
            Assert.AreEqual(expectedValueInHead, actualValueInHead);
        }

        [Test]
        [TestCase(new [] { 888 })]
        [Ignore("Test is not ready!")]
        [Category("Unit")]
        public void ChangeCountPropWhenHeadValueIsAdded(int[] arrayForInsert)
        {
            // Arrange            
            var expectedValueInHead = arrayForInsert[0];
            var linkedListUnderTests = new MyLinkedList();

            // Act
            linkedListUnderTests.AddAtHead(arrayForInsert[0]);

            var actualValueInHead = linkedListUnderTests.Get(0);

            // Assert
            Assert.AreEqual(expectedValueInHead, actualValueInHead);
        }

        #endregion

        #region AddAtTail() Tests

        [Test]
        [TestCase(new [] { 888 })]
        [Category("Unit")]
        public void AddValueAtHeadIfListEmpty(int[] arrayForInsert)
        {
            // Arrange            
            var expectedValueInTail = arrayForInsert[0];
            var linkedListUnderTests = new MyLinkedList();

            // Act
            linkedListUnderTests.AddAtTail(arrayForInsert[0]);

            // Assert
            var actualValueInTail = linkedListUnderTests.Get(0);
            Assert.AreEqual(expectedValueInTail, actualValueInTail);
        }

        [Test]
        [TestCase(new [] { 888 })]
        [Category("Unit")]
        public void CorrectAddValueAtTail(int[] arrayForInsert)
        {
            // Arrange
            var expectedValueInTail = 999;

            var linkedListUnderTests = new MyLinkedList();
            linkedListUnderTests.AddAtHead(arrayForInsert[0]);

            // Act
            linkedListUnderTests.AddAtTail(999);

            // Assert
            var actualValueInTail = linkedListUnderTests.Get(1);
            Assert.AreEqual(expectedValueInTail, actualValueInTail);
        }

        [Test]
        [TestCase(new [] { 888 })]
        [Ignore("Test is not ready!")]
        [Category("Unit")]
        public void ChangeCountPropWhenWhenTailValueIsAdded(int[] arrayForInsert)
        {
            // Arrange            
            var expectedValueInHead = arrayForInsert[0];
            var linkedListUnderTests = new MyLinkedList();

            // Act
            linkedListUnderTests.AddAtHead(arrayForInsert[0]);

            // Assert
            var actualValueInHead = linkedListUnderTests.Get(0);
            Assert.AreEqual(expectedValueInHead, actualValueInHead);
        }

        #endregion

        #region AddAtIndex() Tests

        [Test]
        [TestCase(new [] { 999, 777 })]
        [Category("Unit")]
        public void CorrectAddValueAtIndexBeforeNodeWithThisIndex(int[] arrayForInsert)
        {
            // Arrange
            var expectedValueBeforeIndexNode = 888;

            var linkedListUnderTests = new MyLinkedList();
            linkedListUnderTests.AddAtHead(arrayForInsert[0]);
            linkedListUnderTests.AddAtHead(arrayForInsert[1]);

            // Act
            linkedListUnderTests.AddAtIndex(1, 888);

            // Assert
            var actualValueBeforeIndexNode = linkedListUnderTests.Get(1);
            Assert.AreEqual(expectedValueBeforeIndexNode, actualValueBeforeIndexNode);
        }

        [Test]
        [TestCase(new [] { 888 })]
        [Category("Unit")]
        public void AddValueToTailIfIndexEqualsListLength(int[] arrayForInsert)
        {
            // Arrange
            var expectedValueInTail = CorrectListValue;

            var linkedListUnderTests = new MyLinkedList();
            linkedListUnderTests.AddAtHead(arrayForInsert[0]);
            linkedListUnderTests.AddAtHead(arrayForInsert[0]);

            // Act
            linkedListUnderTests.AddAtIndex(linkedListUnderTests.Count, CorrectListValue);

            // Assert
            var actualValueInTail = linkedListUnderTests.Get(linkedListUnderTests.Count - 1);
            Assert.AreEqual(expectedValueInTail, actualValueInTail);
        }

        [Test]
        [TestCase(new [] { 888 })]
        [Category("Unit")]
        public void NotAddValueToListIfIndexGreaterThanLength(int[] arrayForInsert)
        {
            // Arrange
            var expectedValueInTail = 999;

            var linkedListUnderTests = new MyLinkedList();
            linkedListUnderTests.AddAtHead(arrayForInsert[0]);

            // Act
            linkedListUnderTests.AddAtTail(999);

            // Assert
            Assert.Ignore();
            //var actualValueInTail = linkedListUnderTests.Get(1);
            //Assert.AreEqual(expectedValueInTail, actualValueInTail);
        }

        [Test]
        [TestCase(new [] { 999, 777 })]
        [Category("Unit")]
        public void IncrementListCountWhenValueSuccessfullyAdded(int[] arrayForInsert)
        {
            // Arrange
            var expectedValueBeforeIndexNode = 888;

            var linkedListUnderTests = new MyLinkedList();
            linkedListUnderTests.AddAtHead(arrayForInsert[0]);
            linkedListUnderTests.AddAtHead(arrayForInsert[1]);

            // Act
            linkedListUnderTests.AddAtIndex(1, 888);

            // Assert
            var actualValueBeforeIndexNode = linkedListUnderTests.Get(1);
            Assert.Ignore();
        }

        [Test]
        [TestCase(new [] { 999, 777 })]
        [Category("Unit")]
        public void NotIncrementListCountWhenValueNotAdded(int[] arrayForInsert)
        {
            // Arrange
            var expectedValueBeforeIndexNode = 888;

            var linkedListUnderTests = new MyLinkedList();
            linkedListUnderTests.AddAtHead(arrayForInsert[0]);
            linkedListUnderTests.AddAtHead(arrayForInsert[1]);

            // Act
            linkedListUnderTests.AddAtIndex(1, 888);

            // Assert
            var actualValueBeforeIndexNode = linkedListUnderTests.Get(1);
            Assert.Ignore();
        }

        #endregion

        #region DeleteAtIndex() Tests



        #endregion

        #region Clear() Tests



        #endregion

        #region LeetCode Constraints Tests

        // throw new ArgumentException("Значение должно быть больше либо равно 0, а также меньше либо равно 1000");

        [Test]
        [TestCase(new [] { 888 })]
        [Category("Unit")]
        public void ThrowAnErrorIfIndexOutOfConstraints(int[] arrayForInsert)
        {
            //0 <= index <= 1000
            var downConstraint = 0;
            var upConstraint = 1000;

            // Arrange
            var expectedValueInTail = 999;

            var linkedListUnderTests = new MyLinkedList();
            linkedListUnderTests.AddAtHead(arrayForInsert[0]);

            // Act
            linkedListUnderTests.AddAtTail(999);

            // Assert
            //var actualValueInTail = linkedListUnderTests.Get(1);
            //Assert.AreEqual(expectedValueInTail, actualValueInTail);
            Assert.Ignore();
        }

        [Test]
        [TestCase(new [] { 888 })]
        [Category("Unit")]
        public void ThrowAnErrorIfValueOutOfConstraints(int[] arrayForInsert)
        {
            //0 <= val <= 1000
            var downConstraint = 0;
            var upConstraint = 1000;

            // Arrange
            var expectedValueInTail = 999;

            var linkedListUnderTests = new MyLinkedList();
            linkedListUnderTests.AddAtHead(arrayForInsert[0]);

            // Act
            linkedListUnderTests.AddAtTail(999);

            // Assert
            //var actualValueInTail = linkedListUnderTests.Get(1);
            //Assert.AreEqual(expectedValueInTail, actualValueInTail);
            Assert.Ignore();
        }

        #endregion

        [Test]
        [TestCase(new[] { 1, 2, 3, 4, 5 })]
        //[TestCase(new [] { 1, 2, 3, 4, 5, 6 })]
        [Category("LinkedList")]
        public void GetLinkedListMiddle(int[] inputData)
        {
   
            // Arrange
            var linkedList = TestHelpers.CreateLinkedListFromArray(inputData);

            // Act
            var middleNode = MyLinkedList.GetLinkedListMiddle(linkedList.GetHead());

            // Assert

        }

        [Test]
        [Category("LinkedList")]
        [TestCase(new[] { 1, 3, 5, 7, 9 }, new[] { 2, 4, 6, 8 }, new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 })]
        public void Zip_ReceiveTwoCorrectLinkedLists_ReturnsOneZippedLinkedList(int[] firstData, int[] secondData, int[] expectedResult)
        {
            // Arrange
            var firstLinkedList = TestHelpers.CreateLinkedListFromArray(firstData);
            var secondLinkedList = TestHelpers.CreateLinkedListFromArray(secondData);

            // Act
            var zippedLinkedList = MyLinkedList.Zip(firstLinkedList.GetHead(), secondLinkedList.GetHead());
            
            // Assert
        }

        [Test]
        [Category("LinkedList")]
        [TestCase(new[] { 0 }, new[] { 0 })]
        [TestCase(new[] { 1, 2, 3, 4, 5 }, new[] { 1, 2, 3, 4, 5 })]
        public void ToIntArray_ReturnsArrrayWithLinkedListElements(int[] testCaseData, int[] expectedResult)
        {
            // Arrange
            var linkedList = TestHelpers.CreateLinkedListFromArray(testCaseData);

            // Act
            var actualResult = linkedList.ToIntArray();

            // Assert
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }

    }

}