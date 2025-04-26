namespace LeetCode.LeetCodeSolutions;

public class _1_Two_Sum
{
    
    //brute force solution
    public int[] TwoSum(int[] nums, int target)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = 0; j < nums.Length; j++)
            {
                int outcome = nums[i] + nums[j];
                        
                if (i != j && outcome == target)
                {
                    return new int[] {i, j};
                }
            }
        }
        return [0];
    }
    
    //optimized solution using dictionary
    public int[] TwoSums(int[] nums, int target)
    {
        Dictionary<int, int> dictionary = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int needNum = target - nums[i];

            if (dictionary.ContainsKey(needNum))
            {
                return new int[] { dictionary[needNum], i };
            }
            dictionary[nums[i]] = i;
        }

        throw new ArgumentException("no two sum solution");

    }
}