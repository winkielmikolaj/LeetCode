using LeetCode.LeetCodeSolutions;
using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Channels;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hello into my LeetCode solutions
            //You can find the solutions in the LeetCodeSolutions folder

            var soulution = new Solution();
            soulution.ProductExceptSelf([1, 2, 3, 4]);
        }

        public class Solution
        {
            public int[] ProductExceptSelf(int[] nums)
            {
                int n = nums.Length;
                int[] answer = new int[n];

                answer[0] = 1;
                for (int i = 1; i < n; i++)
                {
                    answer[i] = answer[i - 1] * nums[i - 1];
                }

                int suffix = 1;
                for (int i = n - 1; i >= 0; i--)
                {
                    answer[i] *= suffix;
                    suffix *= nums[i];
                }

                return answer;
            }
        }
    }
}