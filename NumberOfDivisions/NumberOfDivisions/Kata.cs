using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NumberOfDivisions
{
    public class Kata
    {
        public static int Divisions(int n, int divisor)
        {
            int count = 0;
            while (n / divisor > 0)
            {
                n /= divisor;
                count = count + 1;

            }
            return count;
        }
    }
}
