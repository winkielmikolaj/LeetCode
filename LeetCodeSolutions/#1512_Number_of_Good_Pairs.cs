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
    
    
    //better approach using Dictionary to track doubled values to count good pairs also =>
    //restrained a dictionary by nums.Length to save memory
    public int NumIdenticalPairs2(int[] nums)
    {
        int goodPairs = 0;

        Dictionary<int, int> xd = new Dictionary<int, int>(nums.Length);

        for (int i = 0; i < nums.Length; i++)
        {
            if (xd.ContainsKey(nums[i]))
            {
                goodPairs += xd[nums[i]];
                xd[nums[i]]++;
            }
            else
            {
                xd[nums[i]] = 1;
            }
        }

        Console.WriteLine(goodPairs);
        return goodPairs;
    }
}