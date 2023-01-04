// 58. Length of Last Word
// https://leetcode.com/problems/length-of-last-word
// After finishing I realised I could do all of it as a one liner

namespace Length_of_Last_Word;

public partial class Solution {
    public int LengthOfLastWordAttemp2(string s)
    {
        return s.Split(' ', StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries)[^1].Length;
    }
}