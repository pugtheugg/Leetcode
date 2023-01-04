// 35. Search Insert Position
// https://leetcode.com/problems/search-insert-position

namespace C_sharp_Problems;

public class Search_Insert_Position
{
    public int SearchInsert(int[] nums, int target)
    {
        var left = 0;
        var right = nums.Length - 1;
        var mid = 0;

        while (left <= right)
        {
            mid = (left + right) / 2;

            if (nums[mid] == target)
            {
                return mid;
            }
            
            if (target > nums[mid])
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        return left;
    }
}