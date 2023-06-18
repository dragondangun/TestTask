using Test;
using UnitTests;

namespace TestsTest {
    [TestClass]
    public class DoesTrinagleExistsTests {
        [TestMethod]
        public void DoesTrinagleExists_3_4_5() {
            // Arrange
            BadTriangle triangle = new(3,4,5);
            bool expected = true;
            // Act
            bool given = DoesTriangle.Exists(triangle);
            // Assert
            Assert.IsTrue(given == expected);
        }

        [TestMethod]
        public void DoesTrinagleExists_rectangle() {
            // Arrange
            Rectangle rectangle = new(4.5, 4, 6, 2);
            bool expected = false;
            // Act
            bool given = DoesTriangle.Exists(rectangle);
            // Assert
            Assert.IsTrue(given == expected);
        }

        [TestMethod]
        public void DoesTrinagleExists_1_10_40() {
            // Arrange
            BadTriangle triangle = new(1, 10, 50);
            bool expected = false;
            // Act
            bool given = DoesTriangle.Exists(triangle);
            // Assert
            Assert.IsTrue(given == expected);
        }

        [TestMethod]
        public void DoesTrinagleExists_5_n3_10() {
            // Arrange
            BadTriangle triangle = new(5, -3, 10);
            // Act
            bool expected = false;
            // Act
            bool given = DoesTriangle.Exists(triangle);
            // Assert
            Assert.IsTrue(given == expected);
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void DoesTrinagleExists_null() {
            // Arrange
            BadTriangle triangle = null;
            // Act
            // Assert

            DoesTriangle.Exists(triangle);
        }
    }
}