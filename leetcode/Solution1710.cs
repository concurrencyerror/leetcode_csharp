using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.leetcode
{
    internal class Solution1710
    {
        public int MaximumUnits(int[][] boxTypes, int truckSize)
        {
            int result = 0;
            Dictionary<int, int> dictionary = new();
            foreach (var item in boxTypes)
            {
                if (dictionary.ContainsKey(item[1]))
                {
                    dictionary[item[1]] = dictionary[item[1]] + item[0];
                }
                else
                {
                    dictionary.Add(item[1], item[0]);
                }
            }
            foreach (var item in from dic in dictionary orderby dic.Key descending select dic)
            {
                if (truckSize > item.Value)
                {
                    result += item.Value * item.Key;
                    truckSize -= item.Value;
                }
                else
                {
                    result += truckSize * item.Key;
                    break;
                }
            }
            return result;
        }
    }
}
