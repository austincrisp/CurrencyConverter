using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CurrencyConverter.Test
{
    [TestClass]
    public class JPYToTest
    {
        [TestMethod]
        public void JPYToUSDComputesCorrectly()
        {
            var sut = new JPY(73.31, "$");
            Assert.AreEqual(sut.amount, 73.31);
            Assert.AreEqual(sut.ToUSD(), 0.639892, 0.01);
        }

        [TestMethod]
        public void JPYToEURComputesCorrectly()
        {
            var sut = new JPY(16.90, "¥");
            Assert.AreEqual(sut.amount, 16.90);
            Assert.AreEqual(sut.ToJPY(), 0.138711, .5);
        }

        [TestMethod]
        public void JPYToBTCComputesCorrectly()
        {
            var sut = new JPY(31.66, "Ƀ");
            Assert.AreEqual(sut.amount, 31.66);
            Assert.AreEqual(sut.ToBTC(), 0.000316, 0.1);
        }
    }
}
