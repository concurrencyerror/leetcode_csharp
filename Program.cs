using System;
using System.Collections.Generic;
using System.Linq;

namespace leetcode
{
    class Program
    {
        public static void Main()
        {
            DominantIndex747 test= new DominantIndex747();
            int[] t = new int[] { 3, 6, 1, 0 };
            int v = test.DominantIndex(t);
            System.Console.WriteLine(v);
        }
    }
}
