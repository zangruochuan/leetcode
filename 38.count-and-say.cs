/*
 * @lc app=leetcode.cn id=38 lang=csharp
 *
 * [38] 报数
 *
 * https://leetcode-cn.com/problems/count-and-say/description/
 *
 * algorithms
 * Easy (47.02%)
 * Total Accepted:    19K
 * Total Submissions: 40.1K
 * Testcase Example:  '1'
 *
 * 报数序列是一个整数序列，按照其中的整数的顺序进行报数，得到下一个数。其前五项如下：
 * 
 * 1.     1
 * 2.     11
 * 3.     21
 * 4.     1211
 * 5.     111221
 * 
 * 
 * 1 被读作  "one 1"  ("一个一") , 即 11。
 * 11 被读作 "two 1s" ("两个一"）, 即 21。
 * 21 被读作 "one 2",  "one 1" （"一个二" ,  "一个一") , 即 1211。
 * 
 * 给定一个正整数 n（1 ≤ n ≤ 30），输出报数序列的第 n 项。
 * 
 * 注意：整数顺序将表示为一个字符串。
 * 
 * 
 * 
 * 示例 1:
 * 
 * 输入: 1
 * 输出: "1"
 * 
 * 
 * 示例 2:
 * 
 * 输入: 4
 * 输出: "1211"
 * 
 * 
 */
public class Solution
{
    public string CountAndSay(int n)
    {
        if (n == 1)
        {
            return "1";
        }
        string s = "1";
        string returns = "";
        char currentChar = '1';
        for (int i = 0; i < n-1; i++)
        {
            currentChar = s[0];
            int count = 0;
            returns = "";
            for (int j = 0; j < s.Length; j++)
            {
                if (currentChar == s[j])
                {
                    count++;
                }
                else
                {
                    currentChar = s[j];
                    returns += count.ToString() + s[j - 1];
                    count = 1;
                }
                if (j == s.Length - 1)
                {
                    returns += count.ToString() + s[j];
                }
            }
            s = returns;
        }
        return s;
    }
}
