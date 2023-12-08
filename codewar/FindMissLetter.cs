using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.codewar
{
    public static class FindMissLetter
    {
        public static char FindMissingLetter(char[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != array[0]+i) {
                    return array[i];
                }
            }
            return '_';
        }
    }
}
