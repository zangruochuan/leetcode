#
# @lc app=leetcode.cn id=34 lang=python3
#
# [34] 在排序数组中查找元素的第一个和最后一个位置
#

# @lc code=start
class Solution:
    def searchRange(self, nums: List[int], target: int) -> List[int]:
        front = -1
        end = -1
        for i in range(len(nums)):
            if nums[i] == target and front == -1:
                front = i
            if front != -1 and nums[i] != target:
                break
            if front != -1:
                end = i
        return [front, end]


# @lc code=end
