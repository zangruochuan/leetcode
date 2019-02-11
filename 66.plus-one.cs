/*
 * @lc app=leetcode.cn id=66 lang=csharp
 *
 * [66] 加一
 *
 * https://leetcode-cn.com/problems/plus-one/description/
 *
 * algorithms
 * Easy (36.66%)
 * Total Accepted:    33.8K
 * Total Submissions: 91.5K
 * Testcase Example:  '[1,2,3]'
 *
 * 给定一个由整数组成的非空数组所表示的非负整数，在该数的基础上加一。
 * 
 * 最高位数字存放在数组的首位， 数组中每个元素只存储一个数字。
 * 
 * 你可以假设除了整数 0 之外，这个整数不会以零开头。
 * 
 * 示例 1:
 * 
 * 输入: [1,2,3]
 * 输出: [1,2,4]
 * 解释: 输入数组表示数字 123。
 * 
 * 
 * 示例 2:
 * 
 * 输入: [4,3,2,1]
 * 输出: [4,3,2,2]
 * 解释: 输入数组表示数字 4321。
 * 
 * 
 */
using System.Collections.Generic;

public class Solution {
    public int[] PlusOne(int[] digits) {
        for (int i = 0; i < digits.Length; i++)
        {
            digits[digits.Length-i-1]++;
            if (digits[digits.Length-i-1]==10)
            {
                digits[digits.Length-i-1] = 0;
            }
            else
            {
                break;
            }
            if (digits[0] == 0)
            {
                List<int> li = new List<int>();
                li.Add(1);
                for (int j = 0; j < digits.Length; j++)
                {
                    li.Add(0);
                }
                return li.ToArray();
            }
        }
        return digits;
    }
}
