using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCodeSolutions
{
class _20_Valid_Parentheses
    {
        public static bool IsValid(string s)
        {
            
            Stack stack = new Stack();

            stack.Push("()");
            stack.Push("{}");
            stack.Push("[]");

            if (stack.Contains(s))
            {
                return true;
            }
            else
            {
                return false;
            }
        }



    }
}
