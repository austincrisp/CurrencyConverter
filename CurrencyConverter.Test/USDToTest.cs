using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CurrencyConverter.Test
{
    [TestClass]
    public class USDToTest
    {
        [TestMethod]
        public void USDToEURComputesCorrectly()
        {
            var sut = new USD(74.76, "€");
            Assert.AreEqual(sut.amount, 74.76);
            Assert.AreEqual(sut.ToEUR(), 70.2949, 70.35);
        }

        [TestMethod]
        public void USDToJPYComputesCorrectly()
        {
            var sut = new USD(20.32, "¥");
            Assert.AreEqual(sut.amount, 20.32);
            Assert.AreEqual(sut.ToJPY(), 2330.38, 2330.85);
        }

        [TestMethod]
        public void USDToBTCComputesCorrectly()
        {
            var sut = new USD(62.66, "Ƀ");
            Assert.AreEqual(sut.amount, 62.66);
            Assert.AreEqual(sut.ToBTC(), 0.070916, 0.0710);
        }
    }
}
