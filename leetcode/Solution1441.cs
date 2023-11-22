using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.leetcode
{
    internal class Solution1441
    {
        public IList<string> BuildArray(int[] target, int n)
        {
            int cur = 0;
            List<string> list = new List<string>();
            for (int i = 1; i <= n; i++)
            {
                list.Add("Push");
                if (target[cur] != i)
                {
                    list.Add("Pop");
                }
                else
                {
                    cur++;
                    if (cur == target.Length)
                    {
                        break;
                    }
                }

            }
            return list;
        }
    }
}
