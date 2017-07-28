using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AreWeAlternate
{
    public class Kata
    {
        public static bool IsAlt(string word)
        {
            var rv = false;

            var vowels = new char[5] { 'a', 'e', 'i', 'o', 'u' };

            //change to binary
            var binary = word.Select(c => vowels.Contains(c) ? 1 : 0).ToArray();

            //split binary in alternating arrays
            var odd = binary.Where((c, i) => i % 2 != 0).ToArray();
            var even = binary.Where((c, i) => i % 2 == 0).ToArray();

            if ((odd.All(c=>c == 1) && even.All(c => c == 0)) || (odd.All(c => c == 0) && even.All(c => c == 1)))
            {
                rv = true;
            }

            return rv;
        }
    }
}
