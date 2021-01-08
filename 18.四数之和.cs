/*
 * @lc app=leetcode.cn id=18 lang=csharp
 *
 * [18] 四数之和
 */

// @lc code=start
public class Solution {
    public IList<IList<int>> FourSum(int[] nums, int target) {
        Array.Sort(nums);
        IList<IList<int>> result = new List<IList<int>>();
        for (int first = 0; first < nums.Length-3; first++)
        {
            if (first>0 && nums[first] == nums[first-1])
            {
                continue;
            }
            for (int second = first+1; second < nums.Length-2; second++)
            {
                if(second > first+1 && nums[second] == nums[second-1])
                {
                    continue;
                }

                for (int third = second + 1,fourth = nums.Length-1; third < fourth;)
                {
                    if(third > second + 1 && nums[third] == nums[third-1])
                    {
                        third++;
                        continue;
                    }
                    if(fourth < nums.Length -1 && nums[fourth] == nums[fourth + 1])
                    {
                        fourth--;
                        continue;
                    }
                    if (nums[first]+nums[second]+nums[third]+nums[fourth] == target)
                    {
                        result.Add(new List<int>{nums[first],nums[second],nums[third],nums[fourth]});
                    }
                    if (nums[first]+nums[second]+nums[third]+nums[fourth] < target)
                    {
                        third++;
                    }
                    else
                    {
                        fourth--;
                    }
                }
            }
        }
        return result;
    }
}
// @lc code=end

