using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.codewar
{
    public static class SumTwoSmall
    {
        public static int sumTwoSmallestNumbers(int[] numbers)
        {
            /*Array.Sort(numbers);
            return numbers[0] + numbers[1];*/
            return numbers.OrderBy(x => x).Take(2).Sum();
        }
    }
}
