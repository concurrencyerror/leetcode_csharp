using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.leetcode
{
    internal class Solution50
    {
        public int GiveGem(int[] gem, int[][] operations)
        {
            foreach (int[] op in operations)
            {
                int v = gem[op[0]] / 2;
                gem[op[0]] -= v;
                gem[op[1]] += v;
            }
            return gem.Max() - gem.Min();
        }
    }
}
