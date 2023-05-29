using System.Collections.Generic;
using System.Linq;

namespace leetcode;

public class Solution2032
{
    public IList<int> TwoOutOfThree(int[] nums1, int[] nums2, int[] nums3)
    {
        var set1 = nums1.ToHashSet();
        var set2 = nums2.ToHashSet();
        var set3 = nums3.ToHashSet();
        var dictionary = new Dictionary<int, int>();
        MakeUp(dictionary, set1);
        MakeUp(dictionary, set2);
        MakeUp(dictionary, set3);
        return dictionary.Where(item => item.Value >= 2).Select(item => item.Key).ToList();
    }

    private void MakeUp(Dictionary<int, int> dictionary, HashSet<int> set)
    {
        foreach (var i in set)
        {
            if (dictionary.ContainsKey(i))
            {
                dictionary[i] += 1;
            }
            else
            {
                dictionary[i] = 1;
            }
        }
    }
}