using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test {
    public static class DoesTriangle {
        public static bool Exists(ISidesProvider _sides, bool degeneracyCase = false) {
            if(_sides is null)
                throw new ArgumentNullException();

            var sides = _sides.GetSides().ToArray();

            if(sides.Length != 3) {
                return false; // Or throw exception, as you wish
            }

            foreach(var side in sides) {
                if(side <= 0) {
                    return false;
                }
            }

            var A = sides[0];
            var B = sides[1];
            var C = sides[2];

            var AB = A + B;
            var BC = B + C;
            var AC = A + C;

            if(degeneracyCase) {
                return AB >= C &&
                            AC >= B &&
                            BC >= A;
            }
            else {
                return AB > C &&
                            AC > B &&
                            BC > A;
            }
        }
        }

        public static bool Rectangular(ISidesProvider _sides) {
            if(_sides is null)
                throw new ArgumentNullException();

            if(!Exists(_sides))
                throw new ArgumentException();

            var sides = _sides.GetSides().ToArray();
            var aSquare = Math.Pow(sides[0],2);
            var bSquare = Math.Pow(sides[1],2);
            var cSquare = Math.Pow(sides[2],2);
            return aSquare == (bSquare+cSquare) ||
                                bSquare == (aSquare+cSquare) ||
                                cSquare == (bSquare + aSquare);

        }
    }
}
