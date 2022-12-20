public class Solution {
    public int[] PlusOne(int[] digits)
    {
        for (var i = digits.Length-1; i >= 0; i--)
        {
            if (digits[i] < 9)
            {
                digits[i]++; // Int less than 9 so just increment value and break
                break;
            }

            digits[i] = 0; 

            if (i == 0)
            {
                var tmpDigits = new int[digits.Length + 1]; // Create temp array
                tmpDigits[0] = 1;                                // set the prepended value
                Array.Copy(digits, 0, tmpDigits, 1, digits.Length); // copy the old values
                digits = new int[tmpDigits.Length]; // Create new longer array for digits
                Array.Copy(tmpDigits, 0, digits, 0, tmpDigits.Length); // Copy tmp array into new array
            }
        }
        
        return digits;
    }
}