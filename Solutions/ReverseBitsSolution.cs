using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeetCodeSolutions
{
    public class ReverseBitsSolution
    {
        public static long reverseBits(long n)
        {
            long res = 0;

            for (int i = 0; i < 32; i++)
            {
                long bit = (n >> i) & 1;
                res = res | (bit << (31 - i));
            }
            return res;
        }
    } 
}
