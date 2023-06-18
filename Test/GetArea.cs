namespace Test {
    public static class GetArea {
        public static double OfCircle(IRadiusProvider circle) {
            if(circle is null)
                throw new ArgumentNullException("Circle must be not null");

            double radius = circle.GetRadius();
            if(radius < 0) {
                throw new ArgumentException("Radius must be greater or equal to 0");
            }

            return radius*radius*Math.PI;
        }

        public static double OfTriangle(ISidesProvider sides) {
            throw new NotImplementedException();
        }
    }
}