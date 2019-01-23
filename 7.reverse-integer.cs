/*
 * @lc app=leetcode.cn id=7 lang=csharp
 *
 * [7] 整数反转
 *
 * https://leetcode-cn.com/problems/reverse-integer/description/
 *
 * algorithms
 * Easy (30.77%)
 * Total Accepted:    69.4K
 * Total Submissions: 225.4K
 * Testcase Example:  '123'
 *
 * 给出一个 32 位的有符号整数，你需要将这个整数中每位上的数字进行反转。
 * 
 * 示例 1:
 * 
 * 输入: 123
 * 输出: 321
 * 
 * 
 * 示例 2:
 * 
 * 输入: -123
 * 输出: -321
 * 
 * 
 * 示例 3:
 * 
 * 输入: 120
 * 输出: 21
 * 
 * 
 * 注意:
 * 
 * 假设我们的环境只能存储得下 32 位的有符号整数，则其数值范围为 [−231,  231 − 1]。请根据这个假设，如果反转后整数溢出那么就返回 0。
 * 
 */
public class Solution {
    public int Reverse(int x) {
        int y = 0;
        string s = x.ToString();
        for (int i = 0; i < s.Length; i++)
        {
            y += ((int)s[i])*(exp(10)^(s.Length-i-1));
        }
        return y;
    }
}
