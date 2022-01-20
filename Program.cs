using System;
using System.Collections.Generic;
using System.Linq;

namespace leetcode
{
    class Program
    {
        public static void Main()
        {
            ContainsNearbyDuplicate219 a = new ContainsNearbyDuplicate219();
            int[] t = new int[] { 1, 2, 3, 1, 2, 3 };
            bool v = a.ContainsNearbyDuplicate(t, 2);
            System.Console.WriteLine(v);
        }
    }
}
