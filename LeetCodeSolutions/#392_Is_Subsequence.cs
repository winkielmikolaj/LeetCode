namespace LeetCode.LeetCodeSolutions;

public class _392_Is_Subsequence
{
    public bool IsSubsequence(string s, string t)
    {
        int sIndex = 0, tIndex = 0;

        while (sIndex < s.Length && tIndex < t.Length)
        {
            if (s[sIndex] == t[tIndex])
            {
                sIndex++;
            }
            tIndex++;
        }

        return sIndex == s.Length;
    }
}