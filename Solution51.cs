using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode
{
    internal class Solution50
    {
        public int GiveGem(int[] gem, int[][] operations)
        {
            for (int i = 0; i < operations.Length; i++)
            {
                int v = gem[operations[i][0]] / 2;
                gem[operations[i][0]] -= v;
                gem[operations[i][1]] += v;
            }
            return gem.Max() - gem.Min();
        }
    }
}
