using Test;
using UnitTests;

namespace TestsTest {
    [TestClass]
    public class GetTriangleAreaTests {
        [TestMethod]
        public void GetTriangleArea_3_4_5() {
            // Arrange
            Triangle triangle = new(3, 4, 5);
            double expected = 6;
            double error = 0.000001;
            // Act
            double given = GetArea.OfTriangle(triangle);
            // Assert
            bool result = Math.Abs(expected - given) < error;
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void GetTriangleArea_7d2_8d2_9() {
            // Arrange
            Triangle triangle = new(7.2, 8.2, 9);
            double expected = 27.942798715;
            double error = 0.000001;
            // Act
            double given = GetArea.OfTriangle(triangle);
            // Assert
            bool result = Math.Abs(expected - given) < error;
            Assert.IsTrue(result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void GetTriangleArea_10_40_1() {
            // Arrange
            Triangle triangle = new(10, 40, 1);
            // Act
            // Assert
            GetArea.OfTriangle(triangle);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void GetTriangleArea_n3() {
            // Arrange
            BadTriangle triangle = new(-3, 4, 5);
            // Act
            // Assert
            GetArea.OfTriangle(triangle);
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void GetTriangleArea_null() {
            // Arrange
            Triangle triangle = null;
            // Act
            // Assert

            GetArea.OfTriangle(triangle);
        }
    }
}