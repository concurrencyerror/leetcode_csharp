using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace leetcode
{
    internal class Solution2656
    {
        public int MaximizeSum(int[] nums, int k)
        {
            int max = nums.Max();
            int result = 0;
            for (int i = 0; i < k; i++)
            {
                result += max;
                max++;
            }
            return result;
        }
    }
}
