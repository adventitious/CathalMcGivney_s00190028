using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CathalMcGivney_s00190028;

namespace CathalMcGivney_s00190028_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestIncreasePrice()
        {
            // Arrange
            Phone phone = new Phone("Samsung S20", 500.0m, "Android", "/images/Android", "/images/s20.jpg");

            // Act
            phone.IncreasePrice(12.5);

            // Assert
            Assert.AreEqual(phone.Price, 562.5m);
        }
    }
}
