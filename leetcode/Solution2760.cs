using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.leetcode
{
    internal class Solution2760
    {
        public static int LongestAlternatingSubarray(int[] nums, int threshold)
        {
            HashSet<int> set = new();
            for (int i = 0; i < nums.Length; i++)
            {
                int num = nums[i];
                if (num % 2 == 0 && num <= threshold)
                {
                    int result = 1;
                    for (int j = i; j < nums.Length - 1; j++)
                    {
                        if (nums[j] % 2 == nums[j + 1] % 2)
                        {
                            break;
                        }
                        if (nums[j + 1] <= threshold)
                        {
                            result++;
                        }
                        else break;
                    }
                    set.Add(result);
                }
            }
            return set.Count != 0 ? set.Max() : 0;
        }
    }
}
