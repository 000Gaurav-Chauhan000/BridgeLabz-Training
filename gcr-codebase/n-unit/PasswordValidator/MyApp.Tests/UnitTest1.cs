using NUnit.Framework;
using MyApp;

namespace MyApp.Tests
{
    [TestFixture]
    public class TestCases
    {
        private PasswordValidator validator;

        [SetUp]
        public void Setup()
        {
            validator = new PasswordValidator();
        }

        [Test]
        public void ValidPassword_ReturnsTrue()
        {
            Assert.IsTrue(validator.IsValid("Password1"));
            Assert.IsTrue(validator.IsValid("StrongPass123"));
        }

        [Test]
        public void TooShortPassword_ReturnsFalse()
        {
            Assert.IsFalse(validator.IsValid("Pass1"));
        }

        [Test]
        public void NoUppercasePassword_ReturnsFalse()
        {
            Assert.IsFalse(validator.IsValid("password1"));
        }

        [Test]
        public void NoDigitPassword_ReturnsFalse()
        {
            Assert.IsFalse(validator.IsValid("Password"));
        }

        [Test]
        public void NullOrEmptyPassword_ReturnsFalse()
        {
            Assert.IsFalse(validator.IsValid(null));
            Assert.IsFalse(validator.IsValid(""));
        }
    }
}
