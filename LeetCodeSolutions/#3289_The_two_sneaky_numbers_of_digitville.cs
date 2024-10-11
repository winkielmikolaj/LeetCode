using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCodeSolutions
{
    internal class _3289_The_two_sneaky_numbers_of_digitville
    {
        public int[] GetSneakyNumbers(int[] nums)
        {
            HashSet<int> seen = new HashSet<int>();
            List<int> duplicates = new List<int>();

            foreach (int num in nums)
            {

                if (!seen.Add(num))
                {
                    duplicates.Add(num);

                    if (duplicates.Count == 2)
                        break;
                }
            }
            return duplicates.ToArray();
        }
    }
}
