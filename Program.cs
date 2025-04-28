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
            soulution.NumIdenticalPairs([1, 2, 3, 1, 1, 3]);
        }

        public class Solution
        {
            public int NumIdenticalPairs(int[] nums)
            {
                int goodPairs = 0;

                for (int i = 0; i < nums.Length; i++)
                {
                    for (int j = 0; j < nums.Length; j++)
                    {
                        if (nums[i] == nums[j] && i < j)
                        {
                            goodPairs++;
                        }
                    }
                }

                Console.WriteLine(goodPairs);
                return goodPairs;
            }
        }
    }
}