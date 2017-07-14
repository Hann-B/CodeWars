using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TurnAnyWordIntoABeefTaco
{
    public class Kata
    {
        public static string[] Tacofy(string word)
        {
            var list = new List<string>();
            list.Add("shell");
            var letters = word.ToLower().ToCharArray();
            foreach (var letter in letters)
            {
                switch (letter)
                {
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                        list.Add("beef");
                        break;
                    case 't':
                        list.Add("tomato");
                        break;
                    case 'l':
                        list.Add("lettuce");
                        break;
                    case 'c':
                        list.Add("cheese");
                        break;
                    case 'g':
                        list.Add("guacamole");
                        break;
                    case 's':
                        list.Add("salsa");
                        break;
                }
            }
            list.Add("shell");
            var rv = list.ToArray();
            return rv;
        }
    }
}
