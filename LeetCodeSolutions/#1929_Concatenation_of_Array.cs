namespace LeetCode.LeetCodeSolutions;

public class _1929_Concatenation_of_Array
{
    public int[] GetConcatenation(int[] nums)
    {
        int[] ans = nums.Concat(nums).ToArray();
        
        
        return ans;
    }
}