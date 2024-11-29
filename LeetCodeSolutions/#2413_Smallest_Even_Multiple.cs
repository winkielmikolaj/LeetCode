using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCodeSolutions
{
    internal class _2413_Smallest_Even_Multiple
    {
        public static int SmallestEvenMultiple(int n) //2 i n 
        {
            int ans = 0;

            if (n % 2 == 0)
            {
                ans = n;
            }
            else
            {
                ans = 2 * n;
            }

            Console.WriteLine(ans);

            return ans;
        }
    }
}

//Copy to main
//SmallestEvenMultiple(6);
