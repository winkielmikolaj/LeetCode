using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCodeSolutions
{
    internal class _Single_Number
    {

        //linear time complexity O(n)
        public int SingleNumber(int[] nums)
            {
                int outcome = 0;

                for (int i = 0; i < nums.Length; i++)
                {
                    outcome = outcome ^ nums[i];
                }

                return outcome;
            }
    }
}
