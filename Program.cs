using LeetCode.LeetCodeSolutions;
using System.Collections;
using System.Text;

namespace LeetCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Hello into my LeetCode solutions
            //You can find the solutions in the LeetCodeSolutions folder

            Console.WriteLine(ScoreOfString("hello"));

        }

        public static int ScoreOfString(string s)
        {
            int result = 0;
            for (int i = 1; i < s.Length; i++)
            {
                result += Math.Abs(s[i] - s[i - 1]);
            }
            return result;

        }



























        //#20
        //public static bool IsValid(string s, string a)
        //{

        //    Stack stack = new Stack();

        //    stack.Push("()");
        //    stack.Push("{}");
        //    stack.Push("[]");

        //    if (stack.Contains(a))
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
    }
}

