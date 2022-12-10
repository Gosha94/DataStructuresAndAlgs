namespace StepikCourse.Tests
{

    [TestFixture]
    public class BracketsCheckerShould
    {

        [Test]
        [TestCase("([](){ ([])})", "Success")]
        [TestCase("( []() { ([]) } )", "Success")]
        [TestCase("()[]}", "5")]
        [TestCase("{{[()]]", "7")]
        [TestCase("{}()[]", "Success")]
        [TestCase("}", "1")]
        [TestCase("{})", "3")]
        [TestCase("foo(bar[i);", "10")]
        [TestCase("foo(bar);", "Success")]
        [TestCase("{", "1")]
        public void CheckBrackets_ReturnsCorrectResult(string bracketCase, string expectedResult)
        {
            var actualResult = new BracketsChecker().CheckBrackets(bracketCase);
            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }
    }
}