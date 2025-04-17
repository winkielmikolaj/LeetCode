using LeetCode.LeetCodeSolutions;
using System;
using System.Collections;
using System.Linq;
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

            
            
            
            
System.Console.WriteLine("test maszynki codespace");
        }

        public class Solution
        {
            public string LongestCommonPrefix(string[] strs)
            {
                if (strs is null)
                {
                    return "";
                }
                
                bool czyRobicDalej = true;

                string prefix = "";
                
                int index = 0;
                while (czyRobicDalej)
                {
                    char znakDoPorownania;

                    if (strs[0].Length <= index)
                    {
                        break;
                    }

                    znakDoPorownania = strs[0][index];

                    foreach (var word in strs)
                    {
                        if (word.Length <= index || word[index] != znakDoPorownania)
                        {
                            czyRobicDalej = false;
                            break;
                        }
                    }

                    if (czyRobicDalej)
                    {
                        prefix += znakDoPorownania;
                        index++;
                    }
                }

                return prefix;
            }
        }
    }
}