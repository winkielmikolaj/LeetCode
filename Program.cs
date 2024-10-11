using LeetCode.LeetCodeSolutions;
using System;
using System.Collections;
using System.Text;
using System.Threading.Channels;

namespace LeetCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Hello into my LeetCode solutions
            //You can find the solutions in the LeetCodeSolutions folder

            GetSneakyNumbers([0, 1, 1, 0]);


            Console.ReadLine();
        }

        static public int[] GetSneakyNumbers(int[] nums)
        {
            
            HashSet<int> result = new HashSet<int>(nums);

            int[] ans;

            foreach (int num in nums)
            {
                //Console.WriteLine(num);
                ans = new int[num];

                foreach (int an in ans)
                {
                    Console.WriteLine(an);
                }
            }

            
            

            return nums;
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

