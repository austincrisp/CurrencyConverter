using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CurrencyConverter.Test
{
    [TestClass]
    public class BTCToTest
    {
        [TestMethod]
        public void BTCToUSDComputesCorrectly()
        {
            var sut = new BTC(97.90, "$");
            Assert.AreEqual(sut.amount, 97.90);
            Assert.AreEqual(sut.ToUSD(), 85516.14, 1);
        }

        [TestMethod]
        public void BTCToEURComputesCorrectly()
        {
            var sut = new BTC(30.71, "¥");
            Assert.AreEqual(sut.amount, 30.71);
            Assert.AreEqual(sut.ToJPY(), 25237.67, 1);
        }

        [TestMethod]
        public void BTCToJPYComputesCorrectly()
        {
            var sut = new BTC(71.78, "Ƀ");
            Assert.AreEqual(sut.amount, 71.78);
            Assert.AreEqual(sut.ToBTC(), 7186055.85, 1);
        }
    }
}
