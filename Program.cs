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

            MaximumWealth([[1, 5], [99, 1], [3, 5]]);

            Console.ReadLine();
        }

        public static int MaximumWealth(int[][] accounts)
        {
            int sum = 0;

            int theBiggest = 0;

            for (int i = 0; i < accounts.Length; i++)
            {
                sum = accounts[i].Sum();

                if(sum > theBiggest)
                {
                    theBiggest = sum;
                }
            }

            Console.WriteLine(theBiggest);

            return theBiggest;
        }

    }
}

