using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.codewar
{
    public static class JadenCase
    {
        public static string ToJadenCase(this string phrase)
        {
            /*            string[] str = phrase.Split(' ');
                        for (int i = 0; i < str.Length; i++)
                        {
                            string item = str[i];
                            str[i] = string.Concat(item.Substring(0,1).ToUpper(), item.AsSpan(1));
                        }
                        return string.Join(" ",str);*/
            return string.Join(" ", phrase.Split(' ').Select(i => char.ToUpper(i[0]) + i.Substring(1)));
        }
    }
}
