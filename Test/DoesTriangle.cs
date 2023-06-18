using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test {
    public static class DoesTriangle {
        public static bool Exists(ISidesProvider _sides) {
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

            return (sides[0] + sides[1]) > sides[2] &&
                            (sides[0] + sides[2]) > sides[1] &&
                            (sides[1] + sides[2]) > sides[0];
        }

        public static bool Rectangular(ISidesProvider _sides) {
            throw new NotImplementedException();
        }
    }
}
