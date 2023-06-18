using Test;

namespace TestsTest {
    [TestClass]
    public class GetCircleAreaTests {
        [TestMethod]
        public void GetCircleArea_9() {
            // Arrange
            Circle circle = new(9);
            double expected = 81 * Math.PI;
            double error = 0.000001;
            // Act
            double given = GetArea.OfCircle(circle);
            // Assert
            bool result = Math.Abs(expected - given) < error;
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void GetCircleArea_4d5() {
            // Arrange
            Circle circle = new(4.5);
            double expected = 20.25 * Math.PI;
            double error = 0.000001;
            // Act
            double given = GetArea.OfCircle(circle);
            // Assert
            bool result = Math.Abs(expected - given) < error;
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void GetCircleArea_0() {
            // Arrange
            Circle circle = new(0);
            double expected = 0;
            double error = 0.000001;
            // Act
            double given = GetArea.OfCircle(circle);
            // Assert
            bool result = Math.Abs(expected - given) < error;
            Assert.IsTrue(result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void GetCircleArea_n3() {
            // Arrange
            Circle circle = new(-3);
            // Act
            double given = GetArea.OfCircle(circle);
            // Assert
            Assert.ThrowsException<ArgumentException>(() => GetArea.OfCircle(circle));
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void GetCircleArea_null() {
            // Arrange
            Circle circle = null;
            // Act
            // Assert

            GetArea.OfCircle(circle);
        }
    }

    class Circle : IRadiusProvider {
        double radius;
        double Radius {
            get => radius;
            set => radius = value;
        }
        
        public Circle(double r) {
            radius = r;
        }

        public double GetRadius() => Radius;
    }
}