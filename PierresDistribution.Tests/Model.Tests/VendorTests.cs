using PierresDistribution.Models;

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
    }
