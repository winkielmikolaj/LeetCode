namespace LeetCode.LeetCodeSolutions;

public class _Majority_Element
{
    //my code has linear time complexity O(n)
    public int MajorityElement(int[] nums)
            {
                int length = nums.Length;
                int test = length/2;

                Dictionary<int, int> frequency = new Dictionary<int, int>();

                for (int i = 0; i < length; i++)
                {
                    if (frequency.ContainsKey(nums[i]))
                    {
                        frequency[nums[i]] += 1;
                    }
                    else
                    {
                        frequency[nums[i]] = 1;
                    }
                }

                var result = frequency.FirstOrDefault(x => x.Value > test).Key;

                return result;
            }
}