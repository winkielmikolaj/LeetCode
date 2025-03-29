using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCodeSolutions
{
    public class _1637_Widest_Vertical_Area_Between_Two_Points_Containing_No_Points
    {
        public int MaxWidthOfVerticalArea(int[][] points)
        {
            Array.Sort(points, (a, b) => a[0].CompareTo(b[0]));

            int maxWidth = 0;

            for (int i = 1; i < points.Length; i++)
            {
                int width = points[i][0] - points[i - 1][0];
                maxWidth = Math.Max(maxWidth, width);
            }

            return maxWidth;
        }
    }
}
