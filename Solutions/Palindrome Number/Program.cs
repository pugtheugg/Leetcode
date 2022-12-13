public class Solution {
    public bool IsPalindrome(int x)
    {
        string xString = x.ToString();
        
        char[] charArray = xString.ToCharArray();
        Array.Reverse(charArray);
        
        var reversedString = new string(charArray);
        
        return reversedString == xString;
    }
}