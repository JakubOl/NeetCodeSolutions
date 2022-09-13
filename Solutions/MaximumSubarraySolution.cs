using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeetCodeSolutions
{
    public class MaximumSubarraySolution
    {
        public static int MaxSubArray(int[] nums)
        {
            var maxValue = nums[0];
            var curSum = 0;

            foreach(int i in nums)
            {
                if (curSum < 0)
                {
                    curSum = 0;
                }
                curSum += i;
                maxValue = Math.Max(maxValue, curSum);

            }
            return maxValue;
        }
    }
}
