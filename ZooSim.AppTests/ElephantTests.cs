using Microsoft.VisualStudio.TestTools.UnitTesting;
using ZooSim.Domain;

namespace ZooSim.App.Tests
{
    [TestClass()]
    public class ElephantTests
    {
        [TestMethod()]
        public void FeedMeTest()
        {
            // Arrange
            var ellie = new Elephant();
            ellie.Health = 50f;
            float expected = 55f;
            float actual;

            // Act
            ellie.FeedMe(10);
            actual = ellie.Health;

            // Assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod()]
        public void RetardTest()
        {
            // Arrange
            var ellie = new Elephant();
            ellie.Health = 50f;
            float expected = 45f;
            float actual;

            // Act
            ellie.Retard(10);
            actual = ellie.Health;

            // Assert
            Assert.AreEqual(actual, expected);
        }
    }
}