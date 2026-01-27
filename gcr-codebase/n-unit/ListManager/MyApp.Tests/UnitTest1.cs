using NUnit.Framework;
using MyApp;
using System.Collections.Generic;

namespace MyApp.Tests
{
    [TestFixture]
    public class TestCases
    {
        private ListManager manager;
        private List<int> list;

        [SetUp]
        public void Setup()
        {
            manager = new ListManager();
            list = new List<int> { 1, 2, 3 };
        }

        [Test]
        public void AddElement_AddsSuccessfully()
        {
            manager.AddElement(list, 4);
            Assert.AreEqual(4, list.Count);
            Assert.Contains(4, list);
        }

        [Test]
        public void RemoveElement_RemovesSuccessfully()
        {
            bool removed = manager.RemoveElement(list, 2);
            Assert.IsTrue(removed);
            Assert.AreEqual(2, list.Count);
            Assert.IsFalse(list.Contains(2));
        }

        [Test]
        public void RemoveElement_ElementNotFound_ReturnsFalse()
        {
            bool removed = manager.RemoveElement(list, 10);
            Assert.IsFalse(removed);
            Assert.AreEqual(3, list.Count);
        }

        [Test]
        public void GetSize_ReturnsCorrectSize()
        {
            int size = manager.GetSize(list);
            Assert.AreEqual(3, size);

            manager.AddElement(list, 5);
            Assert.AreEqual(4, manager.GetSize(list));
        }
    }
}
