using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreditCardMask
{
    public class Mask
    {
        public static string Maskify(string cc)
        {
            var rv = string.Empty;
            if (cc.Length > 4)
            {
                for (int i = 0; i < cc.Length - 4; i++)
                {
                    rv += "#";
                }
                rv += cc.Substring(cc.Length - 4);
            }
            else
            {
                rv = cc;
            }
            return rv;
        }
    }
}
