using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCodeSolutions
{
    internal class _14_Longest_Common_Prefix
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
