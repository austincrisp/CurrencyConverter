using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CurrencyConverter.Test
{
    [TestClass]
    public class EURToTest
    {
        [TestMethod]
        public void EURToUSDComputesCorrectly()
        {
            var sut = new EUR(47.82, "$");
            Assert.AreEqual(sut.amount, 47.82);
            Assert.AreEqual(sut.ToUSD(), 50.8530, 0.01);
        }

        [TestMethod]
        public void EURToJPYComputesCorrectly()
        {
            var sut = new EUR(60.33, "¥");
            Assert.AreEqual(sut.amount, 60.33);
            Assert.AreEqual(sut.ToJPY(), 7351.66, .5);
        }

        [TestMethod]
        public void EURToBTCComputesCorrectly()
        {
            var sut = new EUR(17.92, "Ƀ");
            Assert.AreEqual(sut.amount, 17.92);
            Assert.AreEqual(sut.ToBTC(), 0.02182, 0.1);
        }
    }
}
