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
            IEnumerable<int> enumerable = from num in nums where num % 2 == 0 && num % 3 == 0 select num;
            int count = enumerable.Count();
            if (count == 0) { return 0; }
            int result = enumerable.Sum();
            return result / count;
        }
    }
}
