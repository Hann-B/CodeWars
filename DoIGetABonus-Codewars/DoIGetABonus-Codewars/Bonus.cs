using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoIGetABonus
{
    public class Bonus
    {
        public static string bonus_time(int salary, bool bonus)
        {
            var total = salary;
            if (bonus == true)
            {
                total = salary * 10;
            }
            return $"${total}";
        }
    }
}

