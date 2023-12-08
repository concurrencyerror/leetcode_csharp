using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.codewar
{
    public static class Square
    {
        public static int SquareDigits(int n)
        {
            if (n == 0) return 0;
            string result = "";
            while (n > 0)
            {
                int item = n % 10;
                result = Math.Pow(item, 2) + result;
                n /= 10;
            }
            return int.Parse(result);
        }
    }
}
