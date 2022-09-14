using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeetCodeSolutions.Solutions
{
    public static class TwoSumIISolution
    {
        public static int[] TwoSum(int[] numbers, int target)
        {
            var pairs = new Dictionary<int, int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (pairs.ContainsKey(numbers[i]))
                {
                   return new int[] { pairs[numbers[i]], i+1 };
                }
                else
                {
                    pairs[target - numbers[i]] = i+1;
                }

            }
            return new int[] { };
        }

        public static int[] TwoSum2(int[] numbers, int target)
        {
            var left = 0;
            var right = numbers.Length - 1;

            var sum = numbers[left] + numbers[right];
            while (left < right)
            {
                if (sum == target)
                {
                    return new[] { left + 1, right + 1 };
                }

                if (sum > target)
                {
                    right--;
                }
                else
                {
                    left++;
                }

                sum = numbers[left] + numbers[right];
            }

            return new int[0];
        }
    }
}
