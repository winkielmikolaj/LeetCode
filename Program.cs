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

            Sum(12, 5);

            Console.ReadLine();
        }

        public static int Sum(int num1, int num2)
        {

            int sum = num1 + num2;

            Console.WriteLine(sum);

            return num1 + num2;
        }
    }
}

