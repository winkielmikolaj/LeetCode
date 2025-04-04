﻿using LeetCode.LeetCodeSolutions;
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

            SmallerNumbersThanCurrent([8, 1, 2, 2, 3]);

            Console.ReadLine();
        }







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




