namespace Length_of_Last_Word;

public partial class Solution {
    public int LengthOfLastWordAttemp2(string s)
    {
        return s.Split(' ', StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries)[^1].Length;
    }
}