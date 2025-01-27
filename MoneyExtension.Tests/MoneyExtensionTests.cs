﻿namespace MoneyExtension.Tests;

[TestClass]
public sealed class MoneyExtensionTests
{
    [TestMethod]
    public void ShouldConvertDecimalToInt()
    {
        decimal value = 279.98M;
        
        var cents = value.ToCents();
        
        Assert.AreEqual(27998, cents);
    }
}
