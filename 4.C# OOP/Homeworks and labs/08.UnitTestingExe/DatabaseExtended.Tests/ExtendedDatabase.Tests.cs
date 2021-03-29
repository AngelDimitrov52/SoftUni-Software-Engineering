
using ExtendedDatabase;
using NUnit.Framework;
using System;

namespace Tests
{
    public class ExtendedDatabaseTests
    {
        private ExtendedDatabase.ExtendedDatabase database;
        [SetUp]

        public void Setup()
        {
            database = new ExtendedDatabase.ExtendedDatabase();
        }

        [Test]
        public void When_AddMoreThanCapasiti_Should_ThrowEx()
        {
            for (int i = 0; i < 16; i++)
            {
                database.Add(new ExtendedDatabase.Person(i, $"Angel{i}"));
            }

            InvalidOperationException ex =
                Assert.Throws<InvalidOperationException>(() => database.Add(new ExtendedDatabase.Person(54, "Throw")));
            Assert.That(ex.Message, Is.EqualTo("Array's capacity must be exactly 16 integers!"));
        }
        [Test]
        public void When_AddTwoPersonsWhithEqualNames_Should_ThrowEx()
        {
            for (int i = 0; i < 5; i++)
            {
                database.Add(new ExtendedDatabase.Person(i, $"Angel{i}"));
            }


            InvalidOperationException ex =
                Assert.Throws<InvalidOperationException>(() => database.Add(new ExtendedDatabase.Person(77, "Angel0")));
            Assert.That(ex.Message, Is.EqualTo("There is already user with this username!"));
        }
        [Test]
        public void When_AddTwoPersonsWhithEqualId_Should_ThrowEx()
        {
            for (int i = 0; i < 5; i++)
            {
                database.Add(new ExtendedDatabase.Person(i, $"Angel{i}"));
            }


            InvalidOperationException ex =
                Assert.Throws<InvalidOperationException>(() => database.Add(new ExtendedDatabase.Person(0, "Angel")));
            Assert.That(ex.Message, Is.EqualTo("There is already user with this Id!"));
        }
        [Test]
        public void When_AddPerson_Should_IncreaseCounter()
        {
            Person person = new Person(32, "Angel");
            database.Add(person);

            Assert.AreEqual(database.Count, 1);
            Person returnPrson = database.FindByUsername("Angel");
            Assert.That(returnPrson.Id, Is.EqualTo(person.Id));
            Assert.That(returnPrson.UserName, Is.EqualTo(person.UserName));

        }
        [Test]
        public void When_CtorIsInvalid_Should_Throw()
        {
            Person[] arr = new Person[17];
            for (int i = 0; i < 17; i++)
            {
                arr[i] = new Person(i, $"Angel{i}");
            }

            ArgumentException ex =
               Assert.Throws<ArgumentException>(() => database = new ExtendedDatabase.ExtendedDatabase(arr));
            Assert.AreEqual(ex.Message, "Provided data length should be in range [0..16]!");
        }
        [Test]
        public void When_CtorIsValid_Should_IncreaseCounter()
        {
            Person[] arr = new Person[13];
            for (int i = 0; i < 13; i++)
            {
                arr[i] = new Person(i, $"Angel{i}");
            }

            database = new ExtendedDatabase.ExtendedDatabase(arr);
            Assert.AreEqual(database.Count, arr.Length);
        }
        [Test]
        public void When_CounterIsZeroAndRemovePerson_ShouldThrow()
        {
            Assert.Throws<InvalidOperationException>(() => database.Remove());
        }
        [Test]
        public void When_UseRemoveMethod_Should_CountreDecrease()
        {
            int n = 5;
            for (int i = 0; i < n; i++)
            {
                database.Add(new Person(i, $"Angel{i}"));
            }
            database.Remove();
            Assert.That(database.Count, Is.EqualTo(n - 1));
            Assert.Throws<InvalidOperationException>(() => database.FindById(n - 1));

        }
        [Test]
        [TestCase(null)]
        [TestCase("")]
        public void FindByUserName_ThrowExeption_WhenIsNullOrEmpty(string userName)
        {
            ArgumentNullException ex =
               Assert.Throws<ArgumentNullException>(() => database.FindByUsername(userName));
            Assert.That(ex.Message, Is.EqualTo("Value cannot be null. (Parameter 'Username parameter is null!')"));
        }
        [Test]
        public void FindByUserName_ThrowExeption_WhenNoUserName()
        {
            database.Add(new Person(1, $"Angel7"));
            InvalidOperationException ex =
               Assert.Throws<InvalidOperationException>(() => database.FindByUsername("Angel"));
            Assert.That(ex.Message, Is.EqualTo("No user is present by this username!"));
        }
        [Test]
        public void FindByUserName_ReturnPerson()
        {
            Person person = new Person(32, "Angel");

            database.Add(person);
            
            Assert.That(database.FindByUsername("Angel").UserName,Is.EqualTo(person.UserName));
            Assert.That(database.FindByUsername("Angel").Id,Is.EqualTo(person.Id));
        }

        [Test]
        [TestCase(-11)]
        public void FindById_ThrowExeption_WhenIdIsNegative(long id)
        {
               Assert.Throws<ArgumentOutOfRangeException>(() => database.FindById(id));
        }
        [Test]
        public void FindById_ThrowExeption_WhenNoIdInDataBase()
        {
            database.Add(new Person(1, $"Angel7"));
            
               Assert.Throws<InvalidOperationException>(() => database.FindById(0));
            
        }
        [Test]
        public void FindById_ReturnPerson()
        {
            Person person = new Person(32, "Angel");

            database.Add(person);

            Assert.That(database.FindById(32).UserName, Is.EqualTo(person.UserName));
            Assert.That(database.FindById(32).Id, Is.EqualTo(person.Id));
        }
    }
}