// 169. Majority Element
// https://leetcode.com/problems/majority-element
// Significantly faster solution than the 1st version

namespace C_sharp_Problems;

public class Majority_Element_V2
{
    public int MajorityElement(int[] nums)
    {
        var len = nums.Length;
        var count = 1;
        var majority = 0;

        if (len < 2)
        {
            return nums[0];
        }
        
        Array.Sort(nums);
        
        for (int i = 1; i < len; i++)
        {
            if (nums[i] == nums[i-1])
            {
                count++;
            }
            else
            {
                count = 1;
            }

            if (count > len/2)
            {
                majority = nums[i];
                break;
            }
        }
        
        return majority;
    }
}