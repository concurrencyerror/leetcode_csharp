using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode
{
    internal class Solution1591
    {
        public int distMoney(int money, int children)
        {
            if (money < children)
            {
                return -1;
            }
            money -= children;
            int cnt = Math.Min(money / 7, children);
            money -= cnt * 7;
            children -= cnt;
            if ((children == 0 && money > 0) || (children == 1 && money == 3))
            {
                cnt--;
            }
            return cnt;
        }
    }
}
