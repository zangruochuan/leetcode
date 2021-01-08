/*
 * @lc app=leetcode.cn id=31 lang=csharp
 *
 * [31] 下一个排列
 */

// @lc code=start
public class Solution {
    public void NextPermutation(int[] nums) {
        int currentPosition = nums.Length-2;
        if (nums.Length == 1)
        {
            return;
        }
        while (true)
        {
            if (nums[currentPosition] < nums[currentPosition+1])
            {
                // var tempValue = nums[currentPosition];
                // nums[currentPosition] = nums[currentPosition+1];
                // nums[currentPosition+1] = tempValue;
                // sort(nums,currentPosition+1);
                break;
            }

            if(currentPosition == 0 && nums[currentPosition] >= nums[currentPosition+1])
            {
                sort(nums,0);
                return;
            }

            currentPosition--;
        }

        for (int i = nums.Length-1; i > currentPosition; i--)
        {
            if (nums[i] > nums[currentPosition])
            {
                var temp = nums[currentPosition];
                nums[currentPosition] = nums[i];
                nums[i] = temp;
                break;
            }
        }
        sort(nums,currentPosition+1);
    }

    private void sort(int[] nums,int startPosition)
    {
        for (int i = startPosition; i < nums.Length-1; i++)
        {
            for (int j = startPosition; j < nums.Length-1; j++)
            {
                if(nums[j] > nums[j+1])
                {
                    var temp1 = nums[j+1];
                    nums[j+1] = nums[j];
                    nums[j] = temp1;
                }
            }
        }
    }
}
// @lc code=end

