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
    }
}