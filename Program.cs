using LeetCode.LeetCodeSolutions;
using System;
using System.Collections;
using System.Text;
using System.Threading.Channels;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hello into my LeetCode solutions
            //You can find the solutions in the LeetCodeSolutions folder

            GetSum(12, 5);

            Console.ReadLine();
        }

        public static int GetSum(int a, int b)
        {
            int[] array = { a, b };

            int ans = 0;

            ans = array.Sum();

            Console.WriteLine(ans);

            return ans;
        }
    }
}

