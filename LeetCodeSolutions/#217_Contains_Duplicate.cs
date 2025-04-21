using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCodeSolutions
{
    internal class _Contains_Duplicate
    {
        public bool ContainsDuplicate(int[] nums)
            {
                    HashSet<int> test = new HashSet<int>();
                    
                    for (int i = 0; i < nums.Length; i++)
                    {
                        
                        if(test.Contains(nums[i]))
                        {
                            
                            return true;
                        }
                        test.Add(nums[i]);
                        
                        
                        
                        
                    }
                    return false;
            }
    }
    
}
