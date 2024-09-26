using LeetCode.LeetCodeSolutions;
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

            int[] nums = [1, 2, 3, 4];

            

            
            int[] ans = nums.Where(x => x % 3 == 1 || x % 3 == 2).ToArray();

            foreach (int item in ans)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(ans.Length);
            
            
        }
        public static int[] GetConcatenation(int[] nums)
        {
            int[] ans = nums.Concat(nums).ToArray();

            foreach (int numbers in ans)
            {
                Console.WriteLine(numbers);
            }
        
            return ans;
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

