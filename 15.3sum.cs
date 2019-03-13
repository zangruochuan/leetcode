/*
 * @lc app=leetcode.cn id=15 lang=csharp
 *
 * [15] 三数之和
 *
 * https://leetcode-cn.com/problems/3sum/description/
 *
 * algorithms
 * Medium (21.23%)
 * Total Accepted:    39.3K
 * Total Submissions: 184.9K
 * Testcase Example:  '[-1,0,1,2,-1,-4]'
 *
 * 给定一个包含 n 个整数的数组 nums，判断 nums 中是否存在三个元素 a，b，c ，使得 a + b + c = 0
 * ？找出所有满足条件且不重复的三元组。
 * 
 * 注意：答案中不可以包含重复的三元组。
 * 
 * 例如, 给定数组 nums = [-1, 0, 1, 2, -1, -4]，
 * 
 * 满足要求的三元组集合为：
 * [
 * ⁠ [-1, 0, 1],
 * ⁠ [-1, -1, 2]
 * ]
 * 
 * 
 */

using System;

public class Solution
{
    public IList<IList<int>> ThreeSum(int[] nums)
    {
        #region 该方法超时
        IList<IList<int>> retl = new List<IList<int>>();
        if (nums.Length < 3)
        {
            return retl;
        } 
        // 数组排序
        // for (int i = nums.Length - 1; i > 0; i--)
        // {
        //     int temp = 0;
        //     for (int j = 0; j < i; j++)
        //     {
        //         if (nums[j] > nums[j + 1])
        //         {
        //             temp = nums[j];
        //             nums[j] = nums[j + 1];
        //             nums[j + 1] = temp;
        //         }
        //     }
        // }

        Array.Sort(nums);

        int p1 = 0;
        int p2 = 0;
        int p3 = 0;

        for (p1 = 0; p1 < nums.Length-2; p1++)
        {
            if (nums[p1]+nums[p1+1]+nums[p1+2]>0)
            {
                break;
            }
            if (p1>0 && nums[p1-1]==nums[p1])
            {
                continue;
            }
            p2 = p1+1;
            p3 = nums.Length-1;

            while (p2 < p3)
            {
                if (nums[p1]+nums[p2]+nums[p3] < 0)
                {
                    p2++;
                    continue;
                }
                if (nums[p1]+nums[p2]+nums[p3] > 0)
                {
                    p3--;
                    continue;
                }

                if (nums[p1]+nums[p2]+nums[p3]==0)
                {
                    retl.Add(new List<int>{ nums[p1],nums[p2],nums[p3]});
                    p2++;
                }
                while (p2<p3 &&nums[p2]==nums[p2-1])
                {
                    p2++;
                }
                while (p2<p3 &&nums[p3]==nums[p3-1])
                {
                    p3--;
                }
            }
        }

        return retl;
        #endregion

        #region 参考方法
        // var res = new List<IList<int>>();
        // Array.Sort(nums);

        // for (int i = 0; i < nums.Length; i++)
        // {
        //     if (i != 0 && nums[i - 1] == nums[i])
        //     {
        //         continue;
        //     }
        //     for (int start = i + 1, end = nums.Length - 1; start < end;)
        //     {
        //         if (start != i + 1 && nums[start] == nums[start - 1])
        //         {
        //             start++;
        //             continue;
        //         }
        //         if (nums[i] + nums[start] + nums[end] == 0)
        //         {
        //             res.Add(new List<int>() { nums[i], nums[start], nums[end] });
        //             start++;
        //         }
        //         else if (nums[i] + nums[start] + nums[end] < 0)
        //         {
        //             start++;
        //         }
        //         else
        //         {
        //             end--;
        //         }
        //     }
        // }

        // return res;
        #endregion

    }
}

