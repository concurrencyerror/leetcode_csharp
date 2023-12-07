using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace leetcode.codewar
{
    public static class DisemvowelImpl
    {
        public static string Disemvowel(string str)
        {
            /*string[] strings = str.Split(' ');
            for (int i = 0; i < strings.Length; i++)
            {
                string s = strings[i];
                string v = Regex.Replace(s, "[aeiouAEIOU]", "");
                strings[i] = v;
            }
            return string.Join(" ", strings);*/
            return Regex.Replace(str, "[aeiou]", "", RegexOptions.IgnoreCase);
        }
    }
}
