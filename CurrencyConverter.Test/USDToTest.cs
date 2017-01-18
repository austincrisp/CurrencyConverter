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
            //var sut = new USD(47.82);
            //Assert.AreEqual(sut.amount, 47.82);
            //Assert.AreEqual(sut.ToEUR(), 44.9663, 0.01);
        }

        [TestMethod]
        public void USDToJPYComputesCorrectly()
        {
            //var sut = new USD(73.31);
            //Assert.AreEqual(sut.amount, 73.31);
            //Assert.AreEqual(sut.ToJPY(), 8381.70, .5);
        }

        [TestMethod]
        public void USDtoBTCComputesCorrectly()
        {
            //var sut = new USD(90.97);
            //Assert.AreEqual(sut.amount, 90.97);
            //Assert.AreEqual(sut.ToBTC(), 0.112905, 0.1);
        }
    }
}
