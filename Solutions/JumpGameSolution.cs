using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeetCodeSolutions
{
    public class JumpGameSolution
    {
        public static bool CanJump(int[] nums)
        {
            int goal = nums.Length - 1;

            for(int i = nums.Length-1; i >= 0; i--)
            {
                if(i + nums[i] >= goal)
                {
                    goal = i;
                }
            }
            return goal == 0;
        }
    }
}
