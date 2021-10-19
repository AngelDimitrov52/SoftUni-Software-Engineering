using NUnit.Framework;
using System;

namespace BankSafe.Tests
{
    public class BankVaultTests
    {
        private BankVault bank;
        [SetUp]
        public void Setup()
        {
            bank = new BankVault();
        }

        [Test]
        public void Ctor_SetCorectli_VaultCells()
        {

            Assert.AreEqual(bank.VaultCells.Count, 12);

        }
        [Test]
        public void Ctor_SetCorectli_VaultCellsIsEqualToZero()
        {
            var item = bank.VaultCells["A1"];

            Assert.AreEqual(item, null);
        }
        [Test]
        public void AddItem_WhenBankContainsKey_ThrowEx()
        {
            Assert.Throws<ArgumentException>(() => bank.AddItem("41", null));
        }
        [Test]
        public void AddItem_WhenBankItemIsNotNull_ThrowEx()
        {
            bank.AddItem("A1", new Item("Go", "34"));
            Assert.Throws<ArgumentException>(() => bank.AddItem("A1", new Item("Go", "34")));
        }
        [Test]
        public void AddItem_WhenBankHaveTwoEqualIds_ThrowEx()
        {
            bank.AddItem("A2", new Item("No", "34"));
            Assert.Throws<InvalidOperationException>(() => bank.AddItem("A1", new Item("Go", "34")));
        }
        [Test]
        public void AddItem_WhenAddCorrect_ShouldReturnString()
        {

            string text = bank.AddItem("A2", new Item("No", "33"));

            Assert.AreEqual(text, $"Item:33 saved successfully!");

        }
        [Test]
        public void AddItem_WhenAddCorrect_ShouldSetCorrectlyItem()
        {

            bank.AddItem("A2", new Item("No", "33"));
            var item = bank.VaultCells["A2"];

            Assert.AreEqual(item.ItemId, "33");
            Assert.AreEqual(item.Owner, "No");
        }
        [Test]
        public void RemoveItem_ThrowEx_WhenCellDoNotExist()
        {
            Assert.Throws<ArgumentException>(() => bank.RemoveItem("322", new Item("Go", "34")));
        }
        [Test]
        public void RemoveItem_ThrowEx_WhenItemDoNotExist()
        {
            Item item = new Item("Go", "34");
            bank.AddItem("A1", item);
            Assert.Throws<ArgumentException>(() => bank.RemoveItem("A1", new Item("No", "34")));
        }
        [Test]
        public void RemoveItem_ShouldWork_Correctly()
        {
            Item item = new Item("Go", "34");
            bank.AddItem("A1", item);
            bank.RemoveItem("A1", item);

            Assert.AreEqual(bank.VaultCells["A1"], null);
           

        }
        [Test]
        public void RemoveItem_ShouldWork_ReturnStringCorrectly()
        {
            Item item = new Item("Go", "34");
            bank.AddItem("A1", item);
            string text = bank.RemoveItem("A1", item);

           
            Assert.AreEqual(text, "Remove item:34 successfully!");

        }


    }
}