using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeetCodeSolutions
{
    public class BestTimeToBuyAndSellStockSolution
    {
        public static int MaxProfit(int[] prices)
        {
            if(prices is null || prices.Length < 1) return 0;

            int left = 0;
            int right = 1;
            int maxProfit = 0;

            while(right < prices.Length)
            {
                if(prices[right] < prices[left])
                {
                    left = right;
                }
                else
                {
                    maxProfit = Math.Max(maxProfit, prices[right] - prices[left]);
                }
                right++;

            }

            return maxProfit;
        }
    }
}
