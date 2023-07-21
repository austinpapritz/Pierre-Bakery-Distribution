namespace PierresDistribution.Tests;
[TestClass]
public class OrderTests : IDisposable
{
    public void Dispose()
    {
        Order.ClearAll();
    }

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

    [TestMethod]
    public void AddOrderItem_AddOrderItemToOrder_Void()
    {
        // Arrange
        Pastry newPastry = new("Pretzel", 4.5m);
        OrderItem newOrderItem = new(newPastry, 5);
        Order newOrder = new(071223);
        List<OrderItem> testList = new List<OrderItem> { newOrderItem };
        // Act
        newOrder.AddOrderItem(newOrderItem);
        // Assert
        CollectionAssert.AreEqual(testList, newOrder.Items);
    }

    [TestMethod]
    public void GetAll_GetAllOrders_ListOrder()
    {
        // Arrange
            // Order 1
            Pastry newPastry = new("Pretzel", 4.5m);
            OrderItem newOrderItem = new(newPastry, 5);
            Order newOrder = new(071223, newOrderItem);
            // Order 2
            Pastry newPastry2 = new("Eclaire", 5.25m);
            OrderItem newOrderItem2 = new(newPastry2, 2);
            Order newOrder2 = new(071423, newOrderItem, newOrderItem2);
            // Order 3
            Bread newBread = new("Whole Wheat", 3.1m);
            OrderItem newOrderItem3 = new(newBread, 10);
            Order newOrder3 = new(071623, newOrderItem, newOrderItem2, newOrderItem3);
            // Test list
            List<Order> testList = new List<Order> { newOrder, newOrder2, newOrder3 };
        // Act
        List<Order> result = Order.GetAll();
        // Assert
        CollectionAssert.AreEqual(testList, result);
    }

}
