
using NUnit.Framework;
using System;
using System.Linq;

namespace Tests
{
    public class DatabaseTests
    {

        private Database.Database database;
        [SetUp]
        public void Setup()
        {
            database = new Database.Database();

        }

        [Test]
        public void When_UseAddMetodAndCapasityIsFull_ShouldThow()
        {

            for (int i = 0; i < 16; i++)
            {
                database.Add(i);
            }

            Assert.Throws<InvalidOperationException>(() => database.Add(17));
        }

        [Test]
        public void When_UseAddMetodAndCapasityIsNotFull_Should_CounterUp()
        {
            int n = 10;
            for (int i = 0; i < n; i++)
            {
                database.Add(12);
            }
            Assert.That(database.Count, Is.EqualTo(n));
        }

        [Test]
        public void When_UseAddMetodAndCapasityIsNotFull_Should_AddElement()
        {
            int element = 123;

            database.Add(element);

            int[] elements = database.Fetch();

            Assert.IsTrue(elements.Contains(element));
        }

        [Test]
        public void When_RemoveAndCounntIsZero_Should_ThrowEx()
        {
            Assert.Throws<InvalidOperationException>(() => database.Remove());

        }

        [Test]

        public void When_Remove_Should_CounterLow()
        {
            for (int i = 0; i < 5; i++)
            {
                database.Add(i);
            }

            database.Remove();
            Assert.AreEqual(database.Count, 4);
        }
        [Test]
        public void When_Remove_Should_DeleteElement()
        {
            int element = 123;

            database.Add(element);
            database.Remove();

            int[] elements = database.Fetch();

            Assert.IsFalse(elements.Contains(element));
        }

        [Test]
        public void When_Fetch_Should_ReturnCopyArray()
        {
            database.Add(1);
            database.Add(2);
            database.Add(3);

            int[] coopyArr = database.Fetch();


            database.Add(5);

            int[] seconCopy = database.Fetch();

            Assert.That(coopyArr, Is.Not.EqualTo(seconCopy));
        }

        [Test]
        public void When_DatabaseIsEmpty_Should_CounterBeZero()
        {
            Assert.That(database.Count, Is.EqualTo(0));
        }

        [Test]
        public void When_UseCtorWhitMoreElementThanCapacity_Should_ThroeEx()
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 12, 11, 12, 131, 41, 51, 61, 7 };
            Assert.Throws<InvalidOperationException>(() => database = new Database.Database(arr));
        }

        [Test]
        public void When_CtorCorectly_Should_AddElements()
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6};

            database = new Database.Database(arr);

            Assert.That(database.Count,Is.EqualTo(arr.Length));
            Assert.That(database.Fetch() ,Is.EquivalentTo(arr));
            
        }



    }
}