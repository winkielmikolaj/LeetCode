using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCodeSolutions
{
    internal class _Search_Insert_Position
    {
        //my version of this task, without including to make this code 0(log n) :)
        public int SearchInsert(int[] nums, int target)
        {
                if(nums.Contains(target))
                {
                    int index = Array.IndexOf(nums, target);

                    return index;
                }
                else
                {
                    List<int> list = nums.ToList();

                    list.Add(target);
                    list.Sort();
                    int[] nums2 = list.ToArray();
                    int elseIndex = Array.IndexOf(nums2, target);

                    return elseIndex;
                }
    }}
    
}
