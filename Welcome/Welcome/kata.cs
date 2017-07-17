using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Welcome
{
    public class kata
    {
        static Dictionary<string, string> greetings = new Dictionary<string, string>()
        {
            {"english", "Welcome" },
            {"czech", "Vitejte"},
            {"danish", "Velkomst"},
            {"dutch", "Welkom" },
            {"estonian", "Tere tulemast"},
            {"finnish", "Tervetuloa" },
            {"flemish", "Welgekomen" },
            {"french", "Bienvenue" },
            {"german", "Willkommen" },
            {"irish", "Failte" },
            {"italian", "Benvenuto" },
            {"latvian", "Gaidits" },
            {"lithuanian", "Laukiamas" },
            {"polish", "Witamy" },
            {"spanish", "Bienvenido" },
            {"swedish", "Valkommen" },
            {"welsh", "Croeso" }
        };

        public static string Greet(string language)
        {
            var rv = string.Empty;
            if (greetings.TryGetValue(language, out rv)){}
            else
            {
                rv = "Welcome";
            }
            return rv;
        }
    }
}
