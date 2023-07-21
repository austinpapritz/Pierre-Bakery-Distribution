namespace PierresDistribution.Tests;

    [TestClass]
    public class VendorTests: IDisposable
    {

    public void Dispose()
    {
        Vendor.ClearAll();
    }
    
        // Tests go here
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
    }
