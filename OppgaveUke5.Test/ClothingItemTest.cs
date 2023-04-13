using System;

namespace OppgaveUke5.Test;

public class ClothingItemTest
{
    [Test]
    public void TestZeroQuantity()
    {
        Assert.Throws<System.ArgumentOutOfRangeException>(() => new ClothingItem("Men's T-Shirt", 0, 20.99, "Large", "Blue"));
    }

    [Test]
    public void TestNegativePrice()
    {
        Assert.Throws<System.ArgumentOutOfRangeException>(() => new ClothingItem("Men's T-Shirt", 20, -1, "Large", "Blue"));
    }

    [Test]
    public void ClothingItemTestOne()
    {
        var expectedPrice = 50 * 20.99;
        ClothingItem shirt = new ClothingItem("Men's T-Shirt", 50, 20.99, "Large", "Blue");


        Assert.That(shirt.CalculateSalePrice(), Is.EqualTo(expectedPrice));
    }
    [Test]
    public void TestZeroPrice()
    {
        ClothingItem shirt = new ClothingItem("Men's T-Shirt", 50, 0, "Large", "Blue");

        Assert.That(shirt.CalculateSalePrice(), Is.EqualTo(0));
    }
}
