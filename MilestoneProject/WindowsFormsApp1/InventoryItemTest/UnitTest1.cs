using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework.Internal;
using InventoryApp;

namespace InventoryItemTests
{
    [TestClass]
    public class InventoryItemTests
    {
        private string name = "Test";
        private decimal price = 32.99m;
        private int quantity = 15;
        private int par = 100;
        private string description = "Test description";
        
        [TestMethod]
        public void InventoryItemTest()
        {
            InventoryItem i = new InventoryItem(name, price, quantity, par, description);
            Assert.AreEqual(name, i.Name);
            Assert.AreEqual(price, i.Price);
            Assert.AreEqual(quantity, i.Quantity);
            Assert.AreEqual(par, i.Par);
            Assert.AreEqual(description, i.Description);
        }
    }
}