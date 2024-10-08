using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCodeSolutions
{
    internal class _1108_Defanging_an_IP_Adress
    {
        public string DefangIPaddr(string address)
        {
            string ans;

            ans = address.Replace(".", "[.]");

            return ans;
        }
    }
}
