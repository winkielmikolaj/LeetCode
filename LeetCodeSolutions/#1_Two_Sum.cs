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
    
    //optimized solution using hashmappping
}