using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MiniSteam.Data.Helpers
{
    public static class Ekstenzije
    {
        public static bool isValid(this string tekst)
        {
            return string.IsNullOrEmpty(tekst);
        }
    

    }
}
