public class Solution {
    public int SingleNumber(int[] nums)
    {
        if (nums.Length == 1)
        {
            return nums[0];
        }
        
        Array.Sort(nums);

        for (var i = 0; i < nums.Length; i++)
        {
            if (i < nums.Length-1 && nums[i + 1] == nums[i])
            {
                i++;
            }
            else
            {
                Console.WriteLine(nums[i]);
                return nums[i];
            }
        }
        return 0;
    }
}