// 26. Remove Duplicates from Sorted Array
// https://leetcode.com/problems/remove-duplicates-from-sorted-array/

namespace C_sharp_Problems;

public class Remove_Duplicates_Array_V2 {
    public int RemoveDuplicates(int[] nums)
    {
        var len = nums.Length;
        
        if (len is 0 or 1)
        {
            return len;
        }

        var j = 0;
        
        for (var i = 0; i < len - 1; i++)
        {
            if (nums[i] != nums[i + 1])
            {
                nums[j++] = nums[i];
            }
        }
        
        nums[j++] = nums[len - 1];

        return j;
    }
}

// Finally managed to figure out how to get decent performance from this question