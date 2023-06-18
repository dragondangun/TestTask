using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test {
    public static class GetPerimeter {
        public static double GetPerimeterOf(ISidesProvider _sides) {
            if(_sides is null)
                throw new ArgumentNullException();

            var sides = _sides.GetSides();

            double result = 0;
            foreach(var side in sides) { 
                if(side <= 0) {
                    throw new ArgumentException();
                }
                result+=side;
            }

            return result;
        }
    }
}
