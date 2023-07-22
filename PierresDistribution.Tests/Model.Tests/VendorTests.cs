namespace PierresDistribution.Tests;

    [TestClass]
    public class VendorTests : IDisposable
    {

        public void Dispose()
        {
            Vendor.ClearAll();
        }
    
        [TestMethod]
        public void VendorConstructor_ConstructANewVendor_Vendor()
        {
            // Arrange
            Vendor newVendor = new("Vendor Name");
            // Assert
            Assert.AreEqual(typeof(Vendor), newVendor.GetType());
        }

        [TestMethod]
        public void GetVendorById_GetVendorById_Vendor()
        {
            // Arrange
            Vendor newVendor = new Vendor("Billy's Bakery");
            int id = newVendor.Id;
            // Act
            Vendor result = Vendor.GetVendorById(id);
            // Assert
            Assert.AreEqual(result, newVendor);
        }

        [TestMethod]
        public void GetAll_ReturnListOfAllVendors_ListVendor()
        {
            // Arrange
            Vendor vendor1 = new("vendor1");
            Vendor vendor2 = new("vendor2");
            Vendor vendor3 = new("vendor3");
            List<Vendor> testList = new List<Vendor> { vendor1, vendor2, vendor3};
            // Act
            List<Vendor> result = Vendor.GetAll();
            // Assert
            Assert.AreEqual(testList.Count, result.Count);
        }

        [TestMethod]
        public void AddOrder_AddOrderToVendorOrders_ListOrder()
        {
            // Arrange
            Order order1 = new(071223);
            Order order2 = new(071323);
            Order order3 = new(071423);
            Vendor vendor = new("Vendor Name2");
            List<Order> testList = new List<Order> { order1, order2, order3};
            List<Order> result = vendor.VendorOrders;
            // Act
            vendor.AddOrder(order1);
            vendor.AddOrder(order2);
            vendor.AddOrder(order3);
            // Assert
            CollectionAssert.AreEqual(testList, result);
        }


    }
