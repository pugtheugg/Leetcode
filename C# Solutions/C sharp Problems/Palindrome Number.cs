// 9. Palindrome Number
// https://leetcode.com/problems/palindrome-number/

namespace C_sharp_Problems;

public class Palindrome_Number
{
    public bool IsPalindrome(int x)
    {
        string xString = x.ToString();
        
        char[] charArray = xString.ToCharArray();
        Array.Reverse(charArray);
        
        var reversedString = new string(charArray);
        
        return reversedString == xString;
    }
}