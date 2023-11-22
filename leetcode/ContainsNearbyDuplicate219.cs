﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.leetcode
{
    internal class ContainsNearbyDuplicate219
    {
        public bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            Dictionary<int, int> map = new();
            for (var i = 0; i < nums.Length; i++)
            {
                if (map.ContainsKey(nums[i]))
                {
                    var under = map[nums[i]] - i;
                    if (Math.Abs(under) <= k)
                    {
                        return true;
                    }
                    map[nums[i]] = i;
                }
                else
                {
                    map.Add(nums[i], i);
                }
            }
            return false;
        }
    }
}
