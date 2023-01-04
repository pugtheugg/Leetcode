// 13. Roman to Integer
// https://leetcode.com/problems/roman-to-integer/

namespace C_sharp_Problems;

public class Roman_To_Int {
    public int RomanToInt(string s) {
        var correspondingValue = new Dictionary<char, int>
        {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 }
        };

        var total = 0;
		
        for (var i = 0; i < s.Length; i++) 
        {
            var currentVal = correspondingValue[s[i]];
			
            if ((i + 1) < s.Length)
            {
                var nextVal = correspondingValue[s[i+1]];
                if (currentVal < nextVal)
                {
                    total += (nextVal - currentVal);
                    i += 1;
                }
                else
                {
                    total += currentVal;
                }
            }
            else
            {
                total += currentVal;
            }
        }

        return total;
    }
}