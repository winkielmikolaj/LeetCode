using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCodeSolutions
{
    internal class _1684_Count_the_Number_of_Consistent_Strings
    {
        public static int CountConsistentStrings(string allowed, string[] words)
        {
            HashSet<char> allowedChars = new HashSet<char>(allowed);

            int ans = 0;

            foreach (string word in words)
            {
                if (word.All(c => allowedChars.Contains(c)))
                {
                    ans++;
                }
            }

            Console.WriteLine(ans);

            return ans;
        }
    }
}

//Copy to main
//CountConsistentStrings("abc" , ["a", "b", "c", "ab", "ac", "bc", "abc"]);
