namespace LeetCode.LeetCodeSolutions;

public class _1512_Number_of_Good_Pairs
{
    
    //#1 solution, there is better one
    public int NumIdenticalPairs(int[] nums)
    {
        int goodPairs = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = 0; j < nums.Length; j++)
            {
                if (nums[i] == nums[j] && i < j)
                {
                    goodPairs++;
                }
            }
        }

        Console.WriteLine(goodPairs);
        return goodPairs;
    }
}