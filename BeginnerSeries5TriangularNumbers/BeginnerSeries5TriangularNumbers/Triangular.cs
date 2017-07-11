using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeginnerSeries5TriangularNumbers
{
    public class Triangular
    {
        public bool isTriangular(int T)
        {
            return true ? (Math.Floor(Math.Sqrt(8 * T + 1)) == Math.Sqrt(8 * T + 1)) : false;
        }
    }
}
