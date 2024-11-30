using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCodeSolutions
{
    internal class _1431_Kid_With_the_Greatest_Number_of_Candies
    {
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

//Copy to main
//KidsWithCandies([2, 3, 5, 1, 3], 3);
