using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultiplesOf3And5
{
    public class Kata
    {
        public static int Solution(int value)
        {
            var rv = 0;
            List<int> multiples = new List<int>();
            for (int i = 1; i < value; i++)
            {
                if (i % 3 == 0 || i % 5 == 0) 
                {
                    multiples.Add(i);
                }               
            }
            rv = multiples.Sum();
            return rv;
        }
    }
}
