namespace LeetCode.LeetCodeSolutions;

public class _58_Length_of_Last_Word
{
    /*Solution Explanation
    I created helper wordLength
    Then I used some built in methods Trim() to clean whitespaces before and after string to be able to operate on last index of the array which I created by splitting this string " ".
    Then I created for loop to be able to display this weird code line
        wordLength = words[words.Length - 1].Length; which means length of word is equal to value in array at index of array length -1.
    If I helped you in any way you can up vote my solution and if you spot some grammar mistakes just ignore them. Eng. is not my first language. :)

    Complexity
        Time complexity:
    s.Trim() = O(n)

    s.Split(" ") = O(n)

        for loop = O(1)

    O(n) + O(n) + O(1) = O(n)
    */
    
    public int LengthOfLastWord(string s)
    {
        int wordLength = 0;

        s = s.Trim();

        string[] words = s.Split(" ");

        for (int i = 0; i < words.Length; i++)
        {
            wordLength = words[words.Length - 1].Length;
        }
                
        return wordLength;
    }
}