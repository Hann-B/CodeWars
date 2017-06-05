using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitCounting_CodeWars
{
    class Program
    {
        //input = number
        public static int CountBits(int n)
        {
            //number to binary
            var binary = Convert.ToString(n, 2);
            return binary.Count(ch => ch == '1');
        }

        static void Main(string[] args)
        {
        }
    }
}
