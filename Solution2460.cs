using System.Collections.Generic;
using System.Linq;

namespace leetcode
{
    internal class Solution2460
    {
        public int[] ApplyOperations(int[] nums)
        {
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] == nums[i + 1])
                {
                    nums[i] = nums[i] * 2;
                    nums[i + 1] = 0;
                }
            }
            IEnumerable<int> enumerable = from num in nums where num != 0 select num;
            int size = enumerable.Count();
            return enumerable.Concat(Enumerable.Repeat(0, nums.Length - size)).ToArray();
        }
    }
}
