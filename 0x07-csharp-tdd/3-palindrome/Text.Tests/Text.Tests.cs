using NUnit.Framework;

namespace Text.Tests
{
    [TestFixture]
    /// <summary>Test cases for 3-palindrome</summary>
    public class Tests
    {
        [Test]
        public void Test1()
        {
            Assert.IsTrue(Str.IsPalindrome("level"));
            Assert.IsTrue(Str.IsPalindrome("Racecar"));
            Assert.IsTrue(Str.IsPalindrome("A man, a plan, a canal: Panama."));
            Assert.IsTrue(Str.IsPalindrome(""));
            Assert.IsFalse(Str.IsPalindrome("Hello"));
        }
    }
}