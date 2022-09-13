using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeetCodeSolutions
{
    public class NumberOf1BitsSolution
    {
        public static int HammingWeight(ulong n)
        {
            int ones = 0;

            for (int i = 0; i < 32; i++)
            {
                if ((n & 1) == 1)
                    ones++;
                n = n >> 1;
            }

            return ones;
        }
    }
}
