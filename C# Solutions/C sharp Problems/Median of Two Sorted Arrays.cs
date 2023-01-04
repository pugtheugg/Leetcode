// 4. Median of Two Sorted Arrays
// https://leetcode.com/problems/median-of-two-sorted-arrays/

namespace C_sharp_Problems;

public class Median_of_Two_Sorted_Arrays
{
    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        int[] numbersArray = nums1.Concat(nums2).ToArray();

        var arrayLen = numbersArray.Count();
        var halfIndex = numbersArray.Count() / 2;
        var sortedNumbers = numbersArray.OrderBy(n=>n);
        double median;
        
        if ((arrayLen % 2) == 0)
        {
            median = (sortedNumbers.ElementAt(halfIndex) + sortedNumbers.ElementAt(halfIndex - 1)) / 2.0;
        } 
        else {
            median = sortedNumbers.ElementAt(halfIndex);
        } 
        
        return median;
    }
}