using System;

public class Class1
{
    public static IList<int> FindWordsContaining(string[] words, char x)
    {
        var result = new List<int>();

        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].Contains(x))
            {
                result.Add(i);
            }
        }

        foreach (int i in result)
        {
            Console.WriteLine(i);
        }

        return result;
    }
}

//Copy to main
//FindWordsContaining(["leet", "code"], 'e');