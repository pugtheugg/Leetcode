// 169. Majority Element
// https://leetcode.com/problems/majority-element

namespace C_sharp_Problems;

public class Majority_Element
{
    public int MajorityElement(int[] nums)
    {
        var len = nums.Length;
        var count = 0;
        var majority = 0;
        
        for (int i = 0; i < len; i++)
        {
            for (int j = 0; j < len; j++)
            {
                if (nums[i] == nums[j])
                {
                    count++;
                }
            }

            if (count > len/2)
            {
                majority = nums[i];
                break;
            }

            count = 0;
        }
        
        return majority;
    }
}
