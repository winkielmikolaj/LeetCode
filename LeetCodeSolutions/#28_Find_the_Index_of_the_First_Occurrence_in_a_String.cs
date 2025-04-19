using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCodeSolutions
{
    internal class _Find_the_Index_of_the_First_Occurrence_in_a_String
    {
        public static int StrStr(string haystuk, string needle)
        {

                if(haystuk.Contains(needle))
                {
                    return haystuk.IndexOf(needle);
                }
                

                return -1;
        }
    }
    
}
