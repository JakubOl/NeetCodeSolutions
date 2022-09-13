using System;
using System.Linq;

namespace NeetCodeSolutions
{
    public class LongestConsecutiveSequenceSolution
    {
        public static int LongestConsecutive(int[] nums)
        {
            Array.Sort(nums);
            if (nums.Count() < 1) return 0;
            int left = nums[0];
            int max = 1;
            int sequence = 1;

            for (int i = 1; i < nums.Length; i++)
            {
                if(nums[i] == left)
                {
                    continue;
                }
                if(nums[i] == left + 1)
                {
                    max += 1;
                }
                else
                {
                    max = 1;
                }
                left = nums[i];
                sequence = Math.Max(sequence, max);
            }
            return sequence;
        }
    }
}
