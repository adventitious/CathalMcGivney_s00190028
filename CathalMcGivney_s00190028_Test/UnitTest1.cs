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
            Phone phone = new Phone();


            phone.Price = 100.0m;


            // Act
            phone.IncreasePrice(12.5);

            // Assert
            Assert.AreEqual(phone.Price, 112.5m);
        }
    }
}
