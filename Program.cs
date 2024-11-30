﻿using LeetCode.LeetCodeSolutions;
using System;
using System.Collections;
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

            KidsWithCandies([2, 3, 5, 1, 3], 3);

            Console.ReadLine();
        }

        public static IList<bool> KidsWithCandies(int[] candies, int extraCandies)
        {
            IList<bool> result = new List<bool>();
            int max = candies.Max();

            for (int i = 0; i < candies.Length; i++)
            {
                candies[i] += extraCandies;

                if (candies[i] >= max)
                {
                    result.Add(true);
                    //Console.WriteLine(true);
                }
                else
                {
                    result.Add(false);
                }
            }

            foreach (var resu in result)
            {
                Console.WriteLine(resu);
            }

                return result;
        }

    }
}

