namespace Test {
    // Надеюсь, я правильно понял, что здесь нужно делать DI.
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

        public static double OfTriangle(ISidesProvider _sides) {
            if(_sides is null)
                throw new ArgumentNullException();

            if(!DoesTriangle.Exists(_sides))
                throw new ArgumentException();

            var semiperim = GetPerimeter.GetPerimeterOf(_sides) / 2;

            var sides = _sides.GetSides().ToArray();

            return Math.Sqrt(semiperim * (semiperim - sides[0]) * (semiperim - sides[1]) * (semiperim - sides[2]));
        }
    }
}