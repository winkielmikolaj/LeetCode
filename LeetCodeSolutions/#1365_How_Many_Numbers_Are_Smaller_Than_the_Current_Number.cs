using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCodeSolutions
{
    internal class _1365_How_Many_Numbers_Are_Smaller_Than_the_Current_Number
    {

        public static int[] SmallerNumbersThanCurrent(int[] nums)
        {
            int[] sortedNums = (int[])nums.Clone();
            Array.Sort(sortedNums);

            Dictionary<int, int> smallerCount = new Dictionary<int, int>();

            for (int i = 0; i < sortedNums.Length; i++)
            {
                if (!smallerCount.ContainsKey(sortedNums[i]))
                {
                    smallerCount[sortedNums[i]] = i;
                }
            }

            int[] result = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                result[i] = smallerCount[nums[i]];
            }

            return result;
        }
    }
}
