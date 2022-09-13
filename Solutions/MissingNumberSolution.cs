using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeetCodeSolutions
{
    public class MissingNumberSolution
    {
        public static int MissingNumber(int[] nums)
        {
            Array.Sort(nums);

            if (nums[0] != 0)
                return 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (i + 1 < nums.Length && nums[i] + 1 != nums[i + 1])
                    return nums[i] + 1;
            }

            return nums[nums.Length - 1] + 1;
        }
    }
}
