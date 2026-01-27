using NUnit.Framework;
using MyApp; 

namespace MyApp.Tests
{
    [TestFixture]
    public class TestCases
    {
        private StringUtils utils;

        [SetUp]
        public void Setup()
        {
            utils = new StringUtils();
        }

        [Test]
        public void Reverse_Word_ReturnsReversed()
        {
            string input = "hello";
            string expected = "olleh";
            Assert.AreEqual(expected, utils.Reverse(input));
        }

        [Test]
        public void IsPalindrome_Palindrome_ReturnsTrue()
        {
            string input = "Madam";
            Assert.IsTrue(utils.IsPalindrome(input));
        }

        [Test]
        public void IsPalindrome_NotPalindrome_ReturnsFalse()
        {
            string input = "Hello";
            Assert.IsFalse(utils.IsPalindrome(input));
        }

        [Test]
        public void ToUpperCase_LowerCaseString_ReturnsUpper()
        {
            string input = "hello";
            string expected = "HELLO";
            Assert.AreEqual(expected, utils.ToUpperCase(input));
        }

        [Test]
        public void Reverse_Null_ReturnsNull()
        {
            Assert.IsNull(utils.Reverse(null));
        }

        [Test]
        public void ToUpperCase_Null_ReturnsNull()
        {
            Assert.IsNull(utils.ToUpperCase(null));
        }
    }
}