using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCodeSolutions
{
    internal class _2894_Divisible_and_Non_divisible_Sums_Difference
    {
        public int DifferenceOfSums(int n, int m)
        {
            int[] ns = new int[n + 1];

            for (int i = 1; i < n + 1; i++)
            {
                ns[i] = i;
                Console.WriteLine(i);
            }

            foreach (int i in ns)
            {
                Console.WriteLine(i);
            }

            int[] ansNotDivisibleBy3 = ns.Where(x => x % m != 0).ToArray();

            int num1 = ansNotDivisibleBy3.Sum();

            int[] ansDivisibleBy3 = ns.Where(x => x % m == 0).ToArray();

            int num2 = ansDivisibleBy3.Sum();

            int ans = num1 - num2;

            return ans;
        }
    }
}
