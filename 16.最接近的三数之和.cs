/*
 * @lc app=leetcode.cn id=16 lang=csharp
 *
 * [16] 最接近的三数之和
 */

// @lc code=start
public class Solution {
    public int ThreeSumClosest(int[] nums, int target) {
        Array.Sort(nums);
        int closestSum = int.MaxValue;
        int minDiff = int.MaxValue;
        for(int i = 0;i<nums.Length;i++)
        {
            for (int start = i+1, end = nums.Length-1; start < end;)
            {
                var tempDiff = Math.Abs(nums[i]+nums[start]+nums[end] - target);
                if (tempDiff < minDiff)
                {
                    minDiff = tempDiff;
                    closestSum = nums[i]+nums[start]+nums[end];
                }
                if (minDiff == 0)
                {
                    break;
                }

                if (nums[i]+nums[start]+nums[end] < target)
                {
                    start++;
                }
                else
                {
                    end--;
                }
            }
        }
        return closestSum;
    }
}
// @lc code=end

