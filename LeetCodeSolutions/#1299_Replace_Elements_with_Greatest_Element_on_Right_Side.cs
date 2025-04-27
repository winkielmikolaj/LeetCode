namespace LeetCode.LeetCodeSolutions;

public class _1299__Replace_Elements_with_Greatest_Element_on_Right_Side
{
    
    //very nice soluion with O(n) time complexity, beats 100% others!!!
    public int[] ReplaceElements(int[] arr)
    {
        int biggest = -1;
        for (int i = arr.Length - 1; i >= 0; i--)
        {
            int current = arr[i];
            arr[i] = biggest;

            if (current > biggest)
            {
                biggest = current;
            }
        }

        arr[arr.Length - 1] = -1;
        return arr;
    }
}