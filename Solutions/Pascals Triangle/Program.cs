// 118. Pascal's Triangle
// https://leetcode.com/problems/pascals-triangle

public class Solution {
    public IList<IList<int>> Generate(int numRows)
    {
        var pascalsNumbers = new List<IList<int>>();
        foreach (var i in Enumerable.Range(1, numRows))
        {
            var c = 1; // Starting value always 1 (left most value of each row)
            int[] row = new int[i]; // Create array to store each rows values
            
            foreach (var j in Enumerable.Range(1, i)) // For each element in row
            {
                row[j-1] = c;
                c = (c * (i - j) / j);
            }
            pascalsNumbers.Add(row.ToArray()); // Add the row to the list
        }
        return pascalsNumbers;
    }
}