using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LostNumberInNumberSequence
{
    public class Kata
    {
        public static int FindDeletedNumber(List<int> startingList, List<int> mixedList)
        {           
            return startingList.Sum() - mixedList.Sum();
        }
    }
}