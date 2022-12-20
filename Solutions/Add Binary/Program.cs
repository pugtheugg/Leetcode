// 67. Add Binary
// https://leetcode.com/problems/add-binary

public class Solution {
    public string AddBinary(string a, string b)
    {
        var result = "";
        var sum = 0;

        int i = a.Length - 1, j = b.Length - 1;

        while (i >= 0 || j >= 0 || sum > 0)
        {
            // Only add if len is not less than 0
            sum += ((i >= 0)? a[i] - '0': 0);
            sum += ((j >= 0)? b[j] - '0': 0);


            if (sum > 1)
            {
                // If sum is 2 we add 0 if sum 3 we add 1
                result = (sum-2) + result;
                sum = 1; // Still have carry
            }
            else
            {
                result = sum.ToString() + result;
                sum = 0;
            }

            i--; j--;
        }
        
        Console.WriteLine(result);
        
        return result;
    }
}