using Microsoft.VisualStudio.TestTools.UnitTesting;
using static ZooSim.Common.RandomNumber;

namespace ZooSim.Common.Tests
{
    [TestClass()]
    public class RandomNumberTests
    {
        [TestMethod()]
        public void GetRandomTest()
        {
            // Arrange
            int actual;

            // Act
            actual = GetRandom(HealthAction.Boost);

            // Assert
            Assert.IsTrue(actual >= 10 && actual <= 25);
        }
    }
}