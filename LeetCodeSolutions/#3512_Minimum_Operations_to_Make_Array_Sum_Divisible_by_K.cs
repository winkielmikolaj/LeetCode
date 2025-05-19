namespace LeetCode.LeetCodeSolutions;

public class _3512_Minimum_Operations_to_Make_Array_Sum_Divisible_by_K
{
    public int MinOperations(int[] nums, int k)
    {
        int sum = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
        }

        return sum % k;
    }
}