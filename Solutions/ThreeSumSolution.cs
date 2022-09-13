using System;
using System.Collections.Generic;

namespace NeetCodeSolutions
{
    public class ThreeSumSolution
    {
        public static IList<IList<int>> ThreeSum(int[] nums) {
        
            var res = new List<IList<int>>();
            Array.Sort(nums);

            for (int i = 0; i < nums.Length; i++) 
            {
                if (i > 0 && nums[i] == nums[i - 1]) continue;

                int l = i + 1; 
                int r = nums.Length - 1;
                while (l < r)
                {
                    int threeSum = nums[i] + nums[l] + nums[r];
                    if(threeSum > 0)
                    {
                        r -= 1;
                    }else if(threeSum < 0)
                    {
                        l += 1;
                    }
                    else
                    {
                        res.Add(new int[]{ nums[i], nums[l], nums[r] });
                        l += 1;
                        while (nums[l] == nums[l - 1] && l < r)
                        {
                            l += 1;
                        }
                    }
                }
            }

            return res;
        }
    }
}
