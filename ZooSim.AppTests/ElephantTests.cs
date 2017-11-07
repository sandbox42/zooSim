using Microsoft.VisualStudio.TestTools.UnitTesting;

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
            ellie.Health = 50;
            float expected = 55;
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
            ellie.Health = 50;
            float expected = 45;
            float actual;

            // Act
            ellie.Retard(10);
            actual = ellie.Health;

            // Assert
            Assert.AreEqual(actual, expected);
        }
    }
}