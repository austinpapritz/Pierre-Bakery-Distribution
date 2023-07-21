using PierresDistribution.Models;

namespace PierresDistribution.Tests;

    [TestClass]
    public class VendorTests 
    {
        // Tests go here
        [TestMethod]
        public void VendorConstructor_ConstructANewVendor_Vendor()
        {
            // Arrange
            Vendor newVendor = new("Vendor Name");
            // Assert
            Assert.AreEqual(typeof(Vendor), newVendor.GetType());
        }
    }
