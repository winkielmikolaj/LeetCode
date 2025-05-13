namespace LeetCode.LeetCodeSolutions;

public class _128_Longest_Consecutive_Sequence
{
    public int LongestConsecutive(int[] nums)
    {
        HashSet<int> test2 = new HashSet<int>(nums);

        int counter = 0;


        foreach (var num in test2)
        {
            if (!test2.Contains(num - 1))
            {
                int currentNum = num;
                int length = 1;

                while (test2.Contains(currentNum + 1))
                {
                    currentNum++;
                    length++;
                }

                counter = Math.Max(counter, length);
            }
        }

        return counter;
    }
}