using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode
{
    internal class DominantIndex747
    {
        public int DominantIndex(int[] nums)
        {
            if (nums.Length == 1)
            {
                return 0;
            }
            int bigger = nums.Max();
            foreach (int i in nums)
            {
                if (bigger != i && bigger < (i * 2))
                {
                    return -1;
                }
            }
            return Array.IndexOf(nums, bigger);
        }
    }
}
