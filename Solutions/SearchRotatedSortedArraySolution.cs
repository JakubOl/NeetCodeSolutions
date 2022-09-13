using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeetCodeSolutions
{
    public class SearchRotatedSortedArraySolution
    {
        public static int Search(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length - 1;
            int middle;

            while(left <= right)
            {
                middle = (left + right) / 2;

                if(nums[middle] == target) return middle;

                if(nums[middle] >= nums[left])
                {
                    if (target > nums[middle] || target < nums[left])
                    {
                        left = middle + 1;
                    }
                    else
                    {
                        right = middle - 1;
                    }
                }
                else
                {
                    if(target < nums[middle] || target > nums[right])
                    {
                        right = middle - 1;
                    }
                    else
                    {
                        left = middle + 1;
                    }
                }

            }
            return -1;

        }
    }
}
