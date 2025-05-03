namespace LeetCode.LeetCodeSolutions;

public class _Top_K_Frequent_Elements
{
    public int[] TopKFrequent(int[] nums, int k)
            {
                int length = nums.Length;
                Dictionary<int, int> numCounter = new Dictionary<int, int>();

                for (int i = 0; i < length; i++)
                {   
                    //if directory already has this value, add 1 to the counter
                    if (numCounter.ContainsKey(nums[i]))
                    {
                        numCounter[nums[i]] += 1;
                    }
                    //else add this to dictionary and set the counter to 1
                    else
                    {
                        numCounter[nums[i]] = 1;
                    }

                }
                return numCounter
                    .OrderByDescending(x => x.Value)
                    .Take(k)
                    .Select(x => x.Key)
                    .ToArray();

            }
}