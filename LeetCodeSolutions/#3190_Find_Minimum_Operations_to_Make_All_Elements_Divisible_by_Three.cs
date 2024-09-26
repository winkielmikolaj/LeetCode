namespace LeetCode.LeetCodeSolutions;

public class _3190_Find_Minimum_Operations_to_Make_All_Elements_Divisible_by_Three
{
    public int MinimumOperations(int[] nums)
    {
        nums = [1, 2, 3, 4];
        
        int[] ans = nums.Where(x => x % 3 == 1 || x % 3 == 2).ToArray();

        foreach (int item in ans)
        {
            Console.WriteLine(item);
        }

        return ans.Length;
    }
}