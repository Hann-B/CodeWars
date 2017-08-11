using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReverseANumber
{
    public class Kata
    {
        public int ReverseNumber(int n)
        {
            var reversed = 0;
            while (n != 0)
            {
                reversed= reversed * 10 + n % 10;
                n = n / 10;
            }

            return reversed;
        }
    }
}
