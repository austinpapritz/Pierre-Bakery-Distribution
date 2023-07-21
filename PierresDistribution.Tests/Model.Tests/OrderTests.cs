namespace PierresDistribution.Tests
{
    [TestClass]
    public class OrderTests
    {
        [TestMethod]
        public void BreadConstructor_CreateBreadProduct_Bread()
        {
            // Arrange
            Bread newBread = new("Pumpernickle", 3.5m);
            // Assert
            Assert.AreEqual(typeof(Bread), newBread.GetType());
        }

        [TestMethod]
        public void PastryConstructor_CreatePastryProduct_Pastry()
        {
            // Arrange
            Pastry newPastry = new("Pretzel", 4.5m);
            // Assert
            Assert.AreEqual(typeof(Pastry), newPastry.GetType());
        }

        [TestMethod]
        public void OrderItemConstructor_CreateAnOrderItem_OrderItem()
        {
            // Arrange
            Pastry newPastry = new("Pretzel", 4.5m);
            OrderItem newOrderItem = new(newPastry, 5);
            // Assert
            Assert.AreEqual(typeof(OrderItem), newOrderItem.GetType());
        }

        [TestMethod]
        public void OrderConstructor_CreateNewOrder_Order()
        {
            // Arrange
            Order newOrder = new(071223);
            // Assert
            Assert.AreEqual(typeof(Order), newOrder.GetType());
        }
    }
}