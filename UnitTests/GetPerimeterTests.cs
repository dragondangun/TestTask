using Test;
using UnitTests;

namespace TestsTest {
    [TestClass]
    public class GetPerimeterTests {
        [TestMethod]
        public void GetPerimeterOf_triangle() {
            // Arrange
            Triangle triangle = new(3, 4, 5);
            double expected = 12;
            double error = 0.000001;
            // Act
            double given = GetPerimeter.GetPerimeterOf(triangle);
            // Assert
            bool result = Math.Abs(expected - given) < error;
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void GetPerimeterOf_rectangle() {
            // Arrange
            Rectangle rectangle= new(3, 4, 5, 6);
            double expected = 18;
            double error = 0.000001;
            // Act
            double given = GetPerimeter.GetPerimeterOf(rectangle);
            // Assert
            bool result = Math.Abs(expected - given) < error;
            Assert.IsTrue(result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void GetPerimeterOf_n3_4_5() {
            // Arrange
            BadTriangle triangle = new(-3, 4, 5);
            // Act
            // Assert
            Assert.ThrowsException<ArgumentException>(() => GetPerimeter.GetPerimeterOf(triangle));
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void GetPerimeterOf_null() {
            // Arrange
            BadTriangle triangle = null;
            // Act
            // Assert
            GetPerimeter.GetPerimeterOf(triangle);
        }
    }
}