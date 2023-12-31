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
    public void AddOrderItems_AddOrderItemsInListToOrder_Void()
    {
        // Arrange
        Pastry newPastry = new("Pretzel", 4.50m);
        Pastry newPastry2 = new("Eclaire", 5.00m);
        OrderItem newOrderItem = new(newPastry, 5);
        OrderItem newOrderItem2 = new(newPastry2, 5);
        Order newOrder = new(071223);
        List<OrderItem> testList = new List<OrderItem> { newOrderItem, newOrderItem2 };
        // Act
        newOrder.AddOrderItems(testList);
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

    [TestMethod]
    public void OrderItemSubtotal_CalculateProductQtyAndProductPrice_Decimal()
    {
        // Arrange
        decimal testPrice = 4.5m * 5;
        Pastry newPastry = new("Pretzel", 4.5m);
        OrderItem newOrderItem = new(newPastry, 5);
        // Act
        decimal result = newOrderItem.Subtotal;
        // Assert
        Assert.AreEqual(testPrice, result);
    }

    [TestMethod]
    public void TotalPriceCalc_SumOfSubtotalsInOrder_Decimal()
    {
        // Arrange
            // OrderItem 1
            Pastry newPastry = new("Pretzel", 4m);
            OrderItem newOrderItem = new(newPastry, 5);
            // OrderItem 2
            Pastry newPastry2 = new("Eclaire", 5m);
            OrderItem newOrderItem2 = new(newPastry2, 2);
            // OrderItem 3
            Bread newBread = new("Whole Wheat", 3m);
            OrderItem newOrderItem3 = new(newBread, 10);
            // Create Order
            Order newOrder = new(071623, newOrderItem, newOrderItem2, newOrderItem3);
            // Test total
            decimal testTotal = (4 * 5) + (5 * 2) + (3 * 10);
        // Act
        decimal result = newOrder.TotalPrice;
        // Assert
        Assert.AreEqual(testTotal, result);
    }

    [TestMethod]
    public void GetAll_GetAllProducts_ListProduct()
    {
        // Arrange
        List<Product> testList = Product._productList;
        List<Product> result = new();
        // Act
        result = Product.GetAll();
        // Assert
        Assert.AreEqual(testList, result);
    }

    [TestMethod]
    public void FindByName_FindAProductByName_Product()
    {
        // Arrange
        Pastry testProduct = new("Macaron", 8.99m);
        // Act
        Product result = Product.FindByName("Macaron");
        // Assert
        Assert.AreEqual(testProduct, result);
    }

    [TestMethod]
    public void FindByDate_FindOrderByDate_Order()
    {
        // Arrange
        Order newOrder = new(010123);
        // Act
        Order result = Order.FindByDate(010123);
        // Assert
        Assert.AreEqual(newOrder, result);
    }

}
