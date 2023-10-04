using ExtensionMethods;

namespace TestProject1
{
    [TestClass]
    public class CustomTest
    {
        [TestMethod]
        public void IsNumberDividedWhole_ReturnsTrue_WhenWholeNumbersAreGiven()
        {
            // Arrange
            double number = 100;
            // Act
            bool result = number.IsNumberDividedWhole(10);
            // Assert
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void IsNumberDividedWhole_ReturnsFalse_WhenFractionNumbersAreGiven()
        {
            // Arrange
            double number = 281;
            // Act
            bool result = number.IsNumberDividedWhole(83);
            // Assert
            Assert.AreEqual(false, result);
        }
    }
}