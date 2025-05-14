namespace LeetCode.LeetCodeSolutions;

public class _49_Group_Anagrams
{
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        Dictionary<string, List<string>> anagrams = new Dictionary<string, List<string>>();

        foreach (var str in strs)
        {
            var key = new string(str.OrderBy(c => c).ToArray());
            if (!anagrams.ContainsKey(key))
            {
                anagrams[key] = new List<string>();
            }

            anagrams[key].Add(str);
        }

        return anagrams.Values.Select(list => (IList<string>)list).ToList();
    }
}