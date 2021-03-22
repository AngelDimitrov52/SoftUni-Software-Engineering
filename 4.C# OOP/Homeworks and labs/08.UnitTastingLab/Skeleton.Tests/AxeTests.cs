using NUnit.Framework;
using System;

[TestFixture]
public class AxeTests
{
    private int attack = 5;
    private int durability = 6;
    private Axe axe;
    private Dummy dummy;

    [SetUp]
    public void SetUp()
    {
        axe = new Axe(attack, durability);
        dummy = new Dummy(5, 6);
    }
    [Test]
    public void When_AxeAtakDummy_Should_LooseDurability()
    {
        axe.Attack(dummy);

        Assert.AreEqual(axe.DurabilityPoints, durability - 1, "Axe Durability do not change after attack!");
    }
    [Test]
    public void When_AxeDurabilityIsNegativeOrZero_Should_ThrowInvalidOperationException()
    {
        dummy = new Dummy(100, 100);

        InvalidOperationException ex = Assert.Throws<InvalidOperationException>(() =>
        {
            for (int i = 0; i < 10; i++)
            {
                axe.Attack(dummy);
            }
        });

        Assert.That(ex.Message, Is.EqualTo("Axe is broken."));
    }
}