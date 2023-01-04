// 26. Remove Duplicates from Sorted Array
// https://leetcode.com/problems/remove-duplicates-from-sorted-array/

namespace C_sharp_Problems;

public class Remove_Duplicates_Array {
    public int RemoveDuplicates(int[] nums)
    {
        var len = nums.Length;
        var k = 0;
        
        for (var i = 0; i < len -1; i++)
        {
            if (nums[i] == 101) break; // All elements from here will be irrelevant 
            
            if (i != len && nums[i] == nums[i+1])
            {
                nums[i + 1] = 101; // Set duplicate to higher than max value 
                i--; // Dont want to increment for loop as the array will be sorted
                k++; // k counts the number of non unique elements 
                Array.Sort(nums);
            }
        }

        return len - k;
    }
}

// Solution does not pass based on speed requirements