using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test;

namespace UnitTests {
    class Circle:IRadiusProvider {
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

    class Triangle:ISidesProvider {
        double[] sides;
        public double[] Sides {
            get => sides;
            set => value.CopyTo(sides, 0);
        }

        public Triangle(double[] sides) {
            if(sides.Length != 3) {
                throw new ArgumentException();
            }

            this.sides = new double[3];
            sides.CopyTo(this.sides, 0);
        }

        public Triangle(double a, double b, double c) {
            if(a <= 0) {
                throw new ArgumentException();
            }
            if(b <= 0) {
                throw new ArgumentException();
            }
            if(c <= 0) {
                throw new ArgumentException();
            }

            sides = new double[3];
            sides[0] = a;
            sides[1] = b;
            sides[2] = c;
        }

        public IEnumerable<double> GetSides() => sides;
    }

    class BadTriangle:ISidesProvider {
        double[] sides;
        public double[] Sides {
            get => sides;
            set => value.CopyTo(sides, 0);
        }

        public BadTriangle(double[] sides) {
            if(sides.Length != 3) {
                throw new ArgumentException();
            }

            this.sides = new double[3];
            sides.CopyTo(this.sides, 0);
        }

        public BadTriangle(double a, double b, double c) {
            sides = new double[3];
            sides[0] = a;
            sides[1] = b;
            sides[2] = c;
        }

        public IEnumerable<double> GetSides() => sides;
    }

    class Rectangle:ISidesProvider {
        double[] sides;
        public double[] Sides {
            get => sides;
            set => value.CopyTo(sides, 0);
        }

        public Rectangle(double[] sides) {
            if(sides.Length != 4) {
                throw new ArgumentException();
            }

            this.sides = new double[4];
            sides.CopyTo(this.sides, 0);
        }

        public Rectangle(double a, double b, double c, double d) {
            if(a <= 0) {
                throw new ArgumentException();
            }
            if(b <= 0) {
                throw new ArgumentException();
            }
            if(c <= 0) {
                throw new ArgumentException();
            }
            if(d <= 0) {
                throw new ArgumentException();
            }

            sides = new double[4];
            sides[0] = a;
            sides[1] = b;
            sides[2] = c;
            sides[3] = d;
        }

        public IEnumerable<double> GetSides() => sides;
    }
}
