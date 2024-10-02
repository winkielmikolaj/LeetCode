namespace LeetCode.LeetCodeSolutions;

public class _2011_Final_value_of_variable_after_performing_operations
{
    public int FinalValueAfterOperations(string[] operations)
    {

        int x = 0;

        foreach (var operation in operations)
        {
            if (operation.Contains('+'))
            {
                x++;
            }
            else if(operation.Contains('-'))
            {
                x--;
            }
            

        }

        return x;
    }
}