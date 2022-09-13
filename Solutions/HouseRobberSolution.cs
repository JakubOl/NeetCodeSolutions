using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeetCodeSolutions
{
    public class HouseRobberSolution
    {
        public static int Rob(int[] nums)
        {
            int rob1 = 0;
            int rob2 = 0;

            foreach(int num in nums)
            {
                var temp = Math.Max(num + rob1, rob2);
                rob1 = rob2;
                rob2 = temp;
            }
            return rob2;
        }
    }
}
