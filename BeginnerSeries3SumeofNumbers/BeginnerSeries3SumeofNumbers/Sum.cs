using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeginnerSeries3SumeofNumbers
{
    public class Sum
    {
        public int GetSum(int a, int b)
        {
            if (a == b)
            {
                return a;
            }
            else
            {
                var min = Math.Min(a, b);
                var max = Math.Max(a, b);
                
                return (max + min)*(max - min + 1) / 2;
            }
            
        }
    }
}
