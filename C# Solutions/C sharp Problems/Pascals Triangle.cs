// 118. Pascal's Triangle
// https://leetcode.com/problems/pascals-triangle

namespace C_sharp_Problems;

public class Pascal_Triangle {
    public IList<IList<int>> Generate(int numRows)
    {
        var pascalsNumbers = new List<IList<int>>();
        foreach (var i in Enumerable.Range(1, numRows))
        {
            var c = 1; // Starting value always 1 (left most value of each row)
            int[] row = new int[i]; // Create array to store each rows values
            
            for (var j = 1; j <= i; j++)
            {
                row[j-1] = c;
                c = (c * (i - j) / j);
            }
            
            pascalsNumbers.Add(row.ToArray()); // Add the row to the list
        }
        return pascalsNumbers;
    }
}