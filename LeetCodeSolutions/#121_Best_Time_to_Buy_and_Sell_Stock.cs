using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCodeSolutions
{
    internal class _Best_Time_To_Buy_And_Sell_Stock
    {
        //solution using O(n) time complexity without using nested for loops
        public int MaxProfit(int[] prices)
            {
                
                int maxProfit = 0;
                int currentPrice = 0;
                int minPrice = prices[0];

                for (int i = 0; i < prices.Length; i++)
                {
                        if (prices[i] < minPrice)
                        {
                            minPrice = prices[i];
                        }

                        currentPrice = prices[i] - minPrice;

                        if(currentPrice > maxProfit)
                        {
                            maxProfit = currentPrice;
                        }
                        if(maxProfit < 0)
                        {
                            maxProfit = 0;
                        }
                }

                return maxProfit;
            }
    }
    
}
