public class Solution {
    public int LengthOfLastWord(string s)
    {
        string[] words = s.Split(' '); // Split the string into words 

        var numOfLetters = 0;

        for (var i = words.Length -1; i >= 0; i--) // Countdown for loop checks from last to first element of array
        {
            if (string.IsNullOrWhiteSpace(words[i])) continue; // If element is whitespace continue
            numOfLetters = words[i].Length; // Otherwise get the length and exit the loop
            break;
        }
        
        return numOfLetters; // Return the value
    }
    
    static void Main(string[] args)
    {
        // Display the number of command line arguments.
        var s = "a";
        var balls = new Solution().LengthOfLastWord(s);
    }
    
}