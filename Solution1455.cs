using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace leetcode
{
    internal class Solution1455
    {
        public int AverageValue(int[] nums)
        {
            var list = (from num in nums where num % 2 == 0 && num % 3 == 0 select num).ToList();
            int count = list.Count();
            if (count == 0)
            {
                return 0;
            }
            int result = list.Sum();
            return result / count;
        }
    }
}