using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCodeSolutions
{
    internal class _2789_Number_of_Employees_Who_Met_Target
    {
        public static int NumberOfEmployeesWhoMetTarget(int[] hours, int target)
        {
            int count = 0;

            for (int i = 0; i < hours.Length; i++)
            {
                if (hours[i] >= target)
                {
                    count++;
                }
            }


            return count;
        }
    }
}