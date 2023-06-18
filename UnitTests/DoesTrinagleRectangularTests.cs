using Test;
using UnitTests;

namespace TestsTest {
    [TestClass]
    public class DoesTrinagleRectangularTests {
        [TestMethod]
        public void DoesTrinagleRectangular_3_4_5() {
            // Arrange
            Triangle triangle = new(3,4,5);
            bool expected = true;
            // Act
            bool given = DoesTriangle.Rectangular(triangle);
            // Assert
            Assert.IsTrue(given == expected);
        }

        [TestMethod]
        public void DoesTrinagleRectangular_rectangle() {
            // Arrange
            Rectangle rectangle = new(4.5, 4, 6, 2);
            bool expected = false;
            // Act
            bool given = DoesTriangle.Rectangular(rectangle);
            // Assert
            Assert.IsTrue(given == expected);
        }

        [TestMethod]
        public void DoesTrinagleRectangular_1_10_40() {
            // Arrange
            Triangle triangle = new(1, 10, 50);
            bool expected = false;
            // Act
            bool given = DoesTriangle.Rectangular(triangle);
            // Assert
            Assert.IsTrue(given == expected);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void DoesTrinagleRectangular_5_n3_10() {
            // Arrange
            BadTriangle triangle = new(5, -3, 10);
            // Act
            // Act
            DoesTriangle.Rectangular(triangle);
            // Assert
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void DoesTrinagleRectangular_null() {
            // Arrange
            Triangle triangle = null;
            // Act
            // Assert

            DoesTriangle.Rectangular(triangle);
        }
    }
}