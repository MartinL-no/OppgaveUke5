using System;

namespace OppgaveUke5.Test;

public class ElectronicItemTest
{
    [Test]
    public void TestZeroQuantity()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => new ElectronicItem("iPhone X", 0, 799.99, "1 year"));
    }
    
    [Test]
    public void TestNegativePrice()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => new ElectronicItem("iPhone X", 25, -1, "1 year"));
    }
    
    [Test]
    public void TestValidElectronicItem()
    {
        var expectedPrice = 25 * 799.99;
        ElectronicItem phone = new ElectronicItem("iPhone X", 25, 799.99, "1 year");

        Assert.That(phone.CalculateSalePrice(), Is.EqualTo(expectedPrice));
    }
    
    [Test]
    public void TestZeroPrice()
    {
        ElectronicItem phone = new ElectronicItem("iPhone X", 25, 0, "1 year");

        Assert.That(phone.CalculateSalePrice(), Is.EqualTo(0));
    }

    [Test]
    public void TestValidVoltageGivenAsParameter()
    {
        Assert.DoesNotThrow(() => new ElectronicItem("iPhone X", 25, 799.99, "1 year", 240));
    }

    [Test]
    public void TestInValidVoltageGivenAsParameter()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => new ElectronicItem("iPhone X", 25, 799.99, "1 year", 1000000));
    }
}
