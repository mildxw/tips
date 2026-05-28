using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using tips;

namespace tips.Tests
{
    [TestClass]
    public class TipCalculatorLogicTests
    {
        [TestMethod]
        public void CalculateTip_WithTenPercent_ReturnsCorrectTip()
        {
            double result = logic.CalculateTip(1000, 10);

            Assert.AreEqual(100, result);
        }
        /*
        [TestMethod]
        public void CalculateTip_WithoutTips_ReturnsZero()
        {
            double result = logic.CalculateTip(1000, 0);

            Assert.AreEqual(0, result);
        }
        

        
        [TestMethod]
        public void CalculateTotal_WithFivePercent_ReturnsCorrectTotal()
        {
            double result = logic.CalculateTotal(2000, 5);

            Assert.AreEqual(2100, result);
        }
        
        
        [TestMethod]
        public void CalculateTotal_WithFifteenPercent_ReturnsCorrectTotal()
        {
            double result = logic.CalculateTotal(1000, 15);

            Assert.AreEqual(1150, result);
        }

        [TestMethod]
        public void CalculatePerGuest_ForTwoGuests_ReturnsCorrectAmount()
        {
            double result = logic.CalculatePerGuest(1000, 2, 10);

            Assert.AreEqual(550, result);
        }

        [TestMethod]
        public void CalculatePerGuest_ForOneGuest_ReturnsTotalAmount()
        {
            double result = logic.CalculatePerGuest(1000, 1, 10);

            Assert.AreEqual(1100, result);
        }

        [TestMethod]
        public void IsGroupBill_WithSeveralGuests_ReturnsTrue()
        {
            bool result = logic.IsGroupBill(3);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsGroupBill_WithOneGuest_ReturnsFalse()
        {
            bool result = logic.IsGroupBill(1);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CalculateTip_WithDifferentPercent_ReturnsNotEqual()
        {
            double result = logic.CalculateTip(1000, 15);

            Assert.AreNotEqual(100, result);
        }

        [TestMethod]
        public void CalculateTip_WithNegativeBill_ThrowsArgumentException()
        {
            Assert.ThrowsException<ArgumentException>(() =>
            logic.CalculateTip(-1000, 10));
        }

        [TestMethod]
        public void CalculateTotal_WithZeroBill_ThrowsArgumentException()
        {
            Assert.ThrowsException<ArgumentException>(() =>
            logic.CalculateTotal(0, 10));
        }

        [TestMethod]
        public void CalculatePerGuest_WithZeroGuests_ThrowsArgumentException()
        {
            Assert.ThrowsException<ArgumentException>(() =>
            logic.CalculatePerGuest(1000, 0, 10));
        }

        [TestMethod]
        public void CalculatePerGuest_WithNegativeGuests_ThrowsArgumentException()
        {
            Assert.ThrowsException<ArgumentException>(() =>
            logic.CalculatePerGuest(1000, -2, 10));
        }

        [TestMethod]
        public void CalculateTip_WithIncorrectPercent_ThrowsArgumentException()
        {
            Assert.ThrowsException<ArgumentException>(() =>
            logic.CalculateTip(1000, 20));
        }*/
    }
}