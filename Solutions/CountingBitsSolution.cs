using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeetCodeSolutions
{
    public class CountingBitsSolution
    {
        public static int[] CountBits(int n)
        {
            var ans = new int[n + 1];

            for (int i = 0; i < ans.Length; i++)
            {
                ans[i] = ans[i / 2] + (i % 2);
            }

            return ans;
        }
    }
}
