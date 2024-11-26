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

            FindWordsContaining(["leet", "code"], 'e');


            Console.ReadLine();
        }

        public static IList<int> FindWordsContaining(string[] words, char x)
        {
            var result = new List<int>();

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Contains(x))
                {
                    result.Add(i);
                }
            }

            foreach (int i in result)
            {
                Console.WriteLine(i);
            }

            return result;
        }
    }
}

