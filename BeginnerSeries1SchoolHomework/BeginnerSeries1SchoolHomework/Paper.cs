using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeginnerSeries1SchoolHomework
{
    public class Paper
    {
        public int Paperwork(int n, int m)
        {
            if (n < 0 || m < 0)
            {
                return 0;
            }
            else
            {
                return n * m;
            }
            
        }
    }
}
