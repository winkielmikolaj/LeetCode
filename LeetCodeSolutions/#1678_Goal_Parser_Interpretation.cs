using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCodeSolutions
{
    internal class _1678_Goal_Parser_Interpretation
    {
        public static string Interpret(string command)
        {
            StringBuilder x = new StringBuilder();
            for (int i = 0; i < command.Length; i++)
            {
                if (command[i] == 'G')
                {
                    x.Append("G");
                }
                else if (command[i] == '(' && command[i + 1] == ')')
                {
                    x.Append("o");
                }
                else if (command[i] == '(' && command[i + 1] == 'a')
                {
                    x.Append("al");
                }
            }

            return x.ToString();
        }
    }
}
