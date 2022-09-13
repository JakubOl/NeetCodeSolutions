using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeetCodeSolutions
{
    public class ClimbStairsSolution
    {
        public static int ClimbStairs(int n)
        {
            int one = 1;
            int two = 1;

            for (int i = 0; i < n - 1; i++)
            {
                var temp = one;
                one += two;
                two = temp;
            }
            return one;
        }
    }
}
