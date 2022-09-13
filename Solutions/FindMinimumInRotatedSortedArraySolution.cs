using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeetCodeSolutions
{
    public class FindMinimumInRotatedSortedArraySolution
    {
        public static int FindMin(int[] nums)
        {
            int left = 0;
            int right = nums.Length - 1;
            int mid;

            while (left < right)
            {
                mid = (right + left) / 2;

                if (nums[mid] < nums[right])
                {
                    right = mid;
                }
                else
                {
                    left = mid + 1;
                }
            }

            return nums[left];
        }
    }
}

