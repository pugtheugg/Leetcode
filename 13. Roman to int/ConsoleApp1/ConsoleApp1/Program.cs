public class Solution {
    public int RomanToInt(string s) {
        var correspondingValue = new Dictionary<char, int>();
		
        correspondingValue.Add('I', 1);
        correspondingValue.Add('V', 5);
        correspondingValue.Add('X', 10);
        correspondingValue.Add('L', 50);
        correspondingValue.Add('C', 100);
        correspondingValue.Add('D', 500);
        correspondingValue.Add('M', 1000);
		
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
            Console.WriteLine(total);
        }

        return total;
    }
}