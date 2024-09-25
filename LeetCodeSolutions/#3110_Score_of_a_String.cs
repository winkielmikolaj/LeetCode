using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCodeSolutions
{
    internal class _3110_Score_of_a_String
    {
        public int ScoreOfString(string s)
        {
            int result = 0;
            for (int i = 1; i < s.Length; i++)
            {
                result += Math.Abs(s[i] - s[i - 1]);
            }
            return result;
        }
    }
}
