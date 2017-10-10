using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AStrangeTripToTheMarket
{
    public static class Kata
    {
        public static bool IsLockNessMonster(string sentence)
        {
            var rv = true;
            if (sentence.ToLower().Contains("tree fiddy")||
                sentence.ToLower().Contains("3.50") ||
                sentence.ToLower().Contains("three fifty"))
            {
                rv = true;
            }
            else
            {
                rv = false;
            }
            return rv;
        }
    }
}
