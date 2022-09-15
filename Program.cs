using NeetCodeSolutions;
using NeetCodeSolutions.Solutions;
using System;

namespace NeetCode
{
    public class NeetCodeSolutions
    {
        public static void Main(string[] args)
        {
            // 1
            var longestConsecutiveSequence = LongestConsecutiveSequenceSolution.LongestConsecutive(new int[] { 0, 3, 7, 2, 5, 8, 4, 6, 0, 1 });
            Console.WriteLine(longestConsecutiveSequence);

            // 2
            var validPalindrome = ValidPalindromeSolution.IsPalindrome("a");
            Console.WriteLine(validPalindrome);

            // 3
            var threeSum = ThreeSumSolution.ThreeSum(new int[] { -1, 0, 1, 2, -1, -4 });
            foreach(var i in threeSum)
            {
                foreach (var j in i)
                {
                    Console.Write(j + ",");
                }
                Console.Write("|");
            }
            Console.WriteLine("");

            // 4
            var numberOf1Bits = NumberOf1BitsSolution.HammingWeight(11111111111111111101);
            Console.WriteLine(numberOf1Bits);

            // 5
            var missingNumber = MissingNumberSolution.MissingNumber(new int[] { 9, 6, 4, 2, 3, 5, 7, 0, 1 });
            Console.WriteLine(missingNumber);

            // 6
            var validParentheses = ValidParenthesesSolution.IsValid("(]");
            Console.WriteLine(validParentheses);

            // 7
            var containerMostWater = ContainerWithMostWaterSolution.MaxArea(new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 });
            Console.WriteLine(containerMostWater);

            // 8
            var bestTimeToBuyAndSellStock = BestTimeToBuyAndSellStockSolution.MaxProfit(new int[] { 1,2 });
            Console.WriteLine(bestTimeToBuyAndSellStock);

            // 9
            var longestSubstringRepeating = LongestSubstringRepeatingSolution.LengthOfLongestSubstring("dvdf");
            Console.WriteLine(longestSubstringRepeating);

            // 10 
            var longestRepeatingCharacterReplacement = LongestRepeatingCharacterReplacemnetSolution.CharacterReplacement("AABABBA", 1);
            Console.WriteLine(longestRepeatingCharacterReplacement);

            // 11 
            var searchRotatedSortedArray = SearchRotatedSortedArraySolution.Search(new int[] { 4, 5, 6, 7, 0, 1, 2 }, 5);
            Console.WriteLine(searchRotatedSortedArray);

            // 12 
            var countingBits = CountingBitsSolution.CountBits(5);
            foreach(var v in countingBits)
            {
                Console.WriteLine(v);
            }

            // 13
            var sumOfTwoIntegers = SumOfTwoIntegersSolution.GetSum(1, 2);
            Console.WriteLine(sumOfTwoIntegers);

            // 14 
            var findMinimumInRotatedSortedArray = FindMinimumInRotatedSortedArraySolution.FindMin(new int[]{ 3,4,5,1,2});
            Console.WriteLine(findMinimumInRotatedSortedArray);

            // 15
            var reverseBits = ReverseBitsSolution.reverseBits(0001111010011100);
            Console.WriteLine(reverseBits);

            // 16
            var reverseLinkedList = ReverseLinkedListSolution.ReverseList(new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(1))))));
            Console.WriteLine(reverseLinkedList);

            // 17
            var mergeTwoSortedLists = MergeTwoSortedListsSolution.MergeTwoLists(new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode())))), new ListNode(3, new ListNode(1, new ListNode(6, new ListNode(3, new ListNode(3))))));
            Console.WriteLine(mergeTwoSortedLists);

            // 18
            ReorderListSolution.ReorderList(new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode())))));


            // 19
            RotateImageSolution.Rotate(new int[][] { new int[]{ 1, 2, 3 }, new int[] { 4, 5, 6 }, new int[] { 7, 8, 9 } });

            // 20
            //var spiralMatrix = SpiralMatrixSolution.SpiralOrder(new int[][] { new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 }, new int[] { 7, 8, 9 } });
            var spiralMatrix2 = SpiralMatrixSolution.SpiralOrder(new int[][] { new int[] { 1, 2 }, new int[] { 3, 4 }});

            foreach (var i in spiralMatrix2)
            {
                Console.WriteLine(i);
            }

            // 21
            var maximumSubarray = MaximumSubarraySolution.MaxSubArray(new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 });
            Console.WriteLine(maximumSubarray);

            // 22
            var jumpGame = JumpGameSolution.CanJump(new int[] { 0 });
            Console.WriteLine(jumpGame);

            // 23
            var climbStairs = ClimbStairsSolution.ClimbStairs(5);
            Console.WriteLine(climbStairs);

            // 24
            var houseRobber = HouseRobberSolution.Rob(new int[] { 1, 2, 3, 1 });
            Console.WriteLine(houseRobber);

            // 25
            var minimumWindowSubstring = MinimumWindowSubstringSolution.MinWindow("ADOBECODEBANC", "ABC");
            Console.WriteLine(minimumWindowSubstring);

            // 26
            var twoSumII = TwoSumIISolution.TwoSum(new[] { 2, 7, 11, 15 }, 9);
            foreach(var num in twoSumII)
            {
                Console.Write(num+",");
            }

            // 27
            var permutationInString = PermutationInStringSolution.CheckInclusion("ab", "eidbaooo");
        }
    }
}
