using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IsThisATriangle
{
    public class Triangle
    {
        public static bool IsTriangle(int a, int b, int c)
        {           
            return true?(a + b > c && a + c > b && b + c > a):false;
        }
    }
}
