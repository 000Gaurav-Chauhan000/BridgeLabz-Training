using NUnit.Framework;
using MyApp;

namespace MyApp.Tests
{
    [TestFixture]
    public class TestCases
    {
        private DateFormatter formatter;

        [SetUp]
        public void Setup()
        {
            formatter = new DateFormatter();
        }

        [Test]
        public void ValidDate_ReturnsFormattedDate()
        {
            Assert.AreEqual("25-01-2026", formatter.FormatDate("2026-01-25"));
            Assert.AreEqual("31-12-2025", formatter.FormatDate("2025-12-31"));
        }

        [Test]
        public void InvalidDate_ReturnsNull()
        {
            Assert.IsNull(formatter.FormatDate("2026/01/25"));
            Assert.IsNull(formatter.FormatDate("25-01-2026"));
            Assert.IsNull(formatter.FormatDate("invalid"));
        }

        [Test]
        public void NullOrEmptyInput_ReturnsNull()
        {
            Assert.IsNull(formatter.FormatDate(null));
            Assert.IsNull(formatter.FormatDate(""));
        }
    }
}
