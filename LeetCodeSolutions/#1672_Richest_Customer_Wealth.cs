using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCodeSolutions
{
    internal class _1672_Richest_Customer_Wealth
    {
        public static int MaximumWealth(int[][] accounts)
        {
            int sum = 0;

            int theBiggest = 0;

            for (int i = 0; i < accounts.Length; i++)
            {
                sum = accounts[i].Sum();

                if (sum > theBiggest)
                {
                    theBiggest = sum;
                }
            }

            return theBiggest;
        }
    }
}
//Copy to main
//MaximumWealth([[1, 5], [7, 3], [3, 5]]);
