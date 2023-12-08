using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace leetcode.codewar
{
    public static class VPin
    {
        public static bool ValidatePin(string pin)
        {
            if (pin.Length == 4 || pin.Length == 6)
            {
                return Regex.IsMatch(pin, "^\\d+\\z");
            }
            return false;
        }
    }
}
