using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCodeSolutions
{
    internal class _371_Sum_of_Two_Integers
    {
        public static int GetSum(int a, int b)
        {
            int[] array = { a, b };

            int ans = 0;

            ans = array.Sum();

            Console.WriteLine(ans);

            return ans;
        }
    }
}


//Copy to main
//GetSum(12, 5);