using NUnit.Framework;
using MyApp;

namespace MyApp.Tests
{
    [TestFixture]
    public class TestCases
    {
        private DatabaseConnection db;

        [SetUp]
        public void Setup()
        {
            db = new DatabaseConnection();
            db.Connect(); 
        }

        [TearDown]
        public void TearDown()
        {
            db.Disconnect(); 
        }

        [Test]
        public void Connection_IsEstablished_InSetup()
        {
            Assert.IsTrue(db.IsConnected, "Database should be connected after Setup");
        }

        [Test]
        public void Connection_IsClosed_AfterTearDown()
        {
            db.Disconnect();
            Assert.IsFalse(db.IsConnected, "Database should be disconnected after TearDown");
        }
    }
}
