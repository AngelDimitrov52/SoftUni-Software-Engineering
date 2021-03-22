using NUnit.Framework;
using System;

[TestFixture]
public class DummyTests
{
    private Dummy dummy;
    private Dummy deadDummy;
    private int health = 5;
    private int experience = 6;

    [SetUp]
    public void SetUp()
    {
        dummy = new Dummy(health, experience);
        deadDummy = new Dummy(-1, experience);
    }

    [Test]
    public void When_DummyIsAttack_Should_LooseHealth()
    {
        int attackPoints = 3;

        dummy.TakeAttack(attackPoints);

        Assert.AreEqual(dummy.Health, health - attackPoints, "Dummy do not loose health");
    }
    [Test]
    public void When_DummyIsDeadAndAttack_Should_ThorowExeption()
    {
        int attackPoints = 3;

        InvalidOperationException ex = Assert.Throws<InvalidOperationException>(() =>
        {
            deadDummy.TakeAttack(attackPoints);
        });

        Assert.AreEqual(ex.Message, "Dummy is dead.");
    }
    [Test]
    public void When_DummyIsDead_Should_CanGiveXpAndThorowExeption()
    {
        int xp = deadDummy.GiveExperience();

        Assert.AreEqual(xp, experience);
    }
    [Test]
    public void When_DummyIsAlive_Should_CanGiveXpAndThorowExeption()
    {
        Assert.That(() => { dummy.GiveExperience(); }, Throws.InvalidOperationException.With.Message.EqualTo("Target is not dead."));
    }

}
