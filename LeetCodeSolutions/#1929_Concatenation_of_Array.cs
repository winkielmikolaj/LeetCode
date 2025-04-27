namespace LeetCode.LeetCodeSolutions;

public class _1929_Concatenation_of_Array
{
    public int[] GetConcatenation(int[] nums)
    {
        int[] ans = nums.Concat(nums).ToArray();
        
        
        return ans;
    }
    
    //much better time complexity O(n)
    
    public int[] GetConcatenationFaster(int[] nums)
    {
        List<int> ans = new List<int>(nums);
                
        for (int i = 0; i < nums.Length; i++)
        {
            ans.Add(nums[i]);
        }

        foreach (var num in ans)
        {
            Console.WriteLine(num);
        }
        return ans.ToArray();
    }
}