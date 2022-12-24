﻿using Challenges.strings_algs;
using Xunit;

namespace Challenges.Tests
{

    public class StringFormatterShould
    {

        [Theory]
        [InlineData(3, "123", "123")]
        [InlineData(3, "abc de fghij", "abc\ndef\nghi\nj")]
        [InlineData(2, "1 23 456", "12\n34\n56")]
        public void Reshape_GetGroupNumberAndDirtyString_ReturnsGrouppedClearString(int testCaseGroupsNum, string testCaseDirtyStr, string expectedVal)
        {
            // Arrange

            // Act
            var actualVal = StringFormatter.Reshape(testCaseGroupsNum, testCaseDirtyStr);

            // Assert
            Assert.Equal(expectedVal, actualVal);
        }
        
    }
}