/*
 * @lc app=leetcode.cn id=4 lang=csharp
 *
 * [4] 寻找两个有序数组的中位数
 *
 * https://leetcode-cn.com/problems/median-of-two-sorted-arrays/description/
 *
 * algorithms
 * Hard (32.56%)
 * Total Accepted:    32.3K
 * Total Submissions: 98.2K
 * Testcase Example:  '[1,3]\n[2]'
 *
 * 给定两个大小为 m 和 n 的有序数组 nums1 和 nums2。
 * 
 * 请你找出这两个有序数组的中位数，并且要求算法的时间复杂度为 O(log(m + n))。
 * 
 * 你可以假设 nums1 和 nums2 不会同时为空。
 * 
 * 示例 1:
 * 
 * nums1 = [1, 3]
 * nums2 = [2]
 * 
 * 则中位数是 2.0
 * 
 * 
 * 示例 2:
 * 
 * nums1 = [1, 2]
 * nums2 = [3, 4]
 * 
 * 则中位数是 (2 + 3)/2 = 2.5
 * 
 * 
 */
public class Solution
{
    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        int[] onlyNums = null;
        if (nums1 == null || nums1.Length == 0)
        {
            onlyNums = nums2;
        }
        else if (nums2 == null || nums2.Length == 0)
        {
            onlyNums = nums1;
        }
        if (onlyNums != null)
        {
            if (onlyNums.Length % 2 == 1)
            {
                return onlyNums[onlyNums.Length / 2];
            }
            else
            {
                return ((double)onlyNums[onlyNums.Length / 2] + (double)onlyNums[onlyNums.Length / 2 - 1]) / 2;
            }
        }

        int totalCount = nums1.Length + nums2.Length;
        int j = 0;
        int k = 0;
        double mid = 0;
        int currentNum = 0;
        int lastNum = 0;
        for (int i = 0; i < totalCount; i++)
        {
            if (j >= nums1.Length)
            {
                lastNum = currentNum;
                currentNum = nums2[k];
                k++;
            }
            else if (k >= nums2.Length)
            {
                lastNum = currentNum;
                currentNum = nums1[j];
                j++;
            }
            else
            {
                if (nums1[j] < nums2[k])
                {
                    lastNum = currentNum;
                    currentNum = nums1[j];
                    j++;
                }
                else
                {
                    lastNum = currentNum;
                    currentNum = nums2[k];
                    k++;
                }
            }
            if (i * 2 >= totalCount)
            {
                if (totalCount % 2 == 0)
                {
                    mid = ((double)currentNum + (double)lastNum) / 2;
                    break;

                }
                else
                {
                    mid = lastNum;
                    break;
                }
            }
        }
        return mid;
    }
}
