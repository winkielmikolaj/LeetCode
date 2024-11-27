using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCodeSolutions
{
    internal class _3280_Convert_Date_to_Binary
    {
        public static string ConvertDateToBinary(string date)
        {
            string[] spliting = date.Split("-");

            string year = spliting[0];
            string month = spliting[1];
            string day = spliting[2];

            int yearInt = Convert.ToInt32(year);
            int monthInt = Convert.ToInt32(month);
            int dayInt = Convert.ToInt32(day);

            string binarna = yearInt.ToString("B");

            string binarnb = monthInt.ToString("B");

            string binarnc = dayInt.ToString("B");

            string ans = $"{binarna}-{binarnb}-{binarnc}";

            Console.WriteLine(ans);

            return ans;
        }
    }
}

//Copy to main
//ConvertDateToBinary("2080-02-29");