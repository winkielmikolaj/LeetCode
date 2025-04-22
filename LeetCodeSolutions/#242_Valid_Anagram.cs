namespace LeetCode.LeetCodeSolutions;

public class _242_Valid_Anagram
{
    public bool IsAnagram(string s, string t)
    {
        //yeah, it is boring bruteforce but hashmap approach was too hard
        char[] sArray = s.ToCharArray();
        char[] tArray = t.ToCharArray();
        Array.Sort(sArray);
        Array.Sort(tArray);
                
        if (new string(sArray) == new string(tArray))
        {
            return true;
        }

        return false;
    }
}