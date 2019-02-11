/*
 * @lc app=leetcode.cn id=67 lang=csharp
 *
 * [67] 二进制求和
 *
 * https://leetcode-cn.com/problems/add-binary/description/
 *
 * algorithms
 * Easy (45.23%)
 * Total Accepted:    14.8K
 * Total Submissions: 32.4K
 * Testcase Example:  '"11"\n"1"'
 *
 * 给定两个二进制字符串，返回他们的和（用二进制表示）。
 * 
 * 输入为非空字符串且只包含数字 1 和 0。
 * 
 * 示例 1:
 * 
 * 输入: a = "11", b = "1"
 * 输出: "100"
 * 
 * 示例 2:
 * 
 * 输入: a = "1010", b = "1011"
 * 输出: "10101"
 * 
 */
public class Solution {
    public string AddBinary(string a, string b) {
        int Length = a.Length>b.Length?a.Length:b.Length;
        int pflag = 0;
        string s = "";
        for (int i = 0; i < Length; i++)
        {
            int aa = a.Length>i?int.Parse(a[a.Length-i-1].ToString()):0;
            int bb = b.Length>i?int.Parse(b[b.Length-i-1].ToString()):0;
            s = ((aa+bb+pflag)%2).ToString() + s;
            if (aa+bb+pflag > 1)
            {
                pflag = 1;
            }
            else
            {
                pflag = 0;
            }
        }
        if (pflag == 1)
        {
            s = "1"+s;
        }
        return s;
    }
}
