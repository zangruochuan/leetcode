/*
 * @lc app=leetcode.cn id=20 lang=csharp
 *
 * [20] 有效的括号
 *
 * https://leetcode-cn.com/problems/valid-parentheses/description/
 *
 * algorithms
 * Easy (35.50%)
 * Total Accepted:    40.5K
 * Total Submissions: 113.1K
 * Testcase Example:  '"()"'
 *
 * 给定一个只包括 '('，')'，'{'，'}'，'['，']' 的字符串，判断字符串是否有效。
 * 
 * 有效字符串需满足：
 * 
 * 
 * 左括号必须用相同类型的右括号闭合。
 * 左括号必须以正确的顺序闭合。
 * 
 * 
 * 注意空字符串可被认为是有效字符串。
 * 
 * 示例 1:
 * 
 * 输入: "()"
 * 输出: true
 * 
 * 
 * 示例 2:
 * 
 * 输入: "()[]{}"
 * 输出: true
 * 
 * 
 * 示例 3:
 * 
 * 输入: "(]"
 * 输出: false
 * 
 * 
 * 示例 4:
 * 
 * 输入: "([)]"
 * 输出: false
 * 
 * 
 * 示例 5:
 * 
 * 输入: "{[]}"
 * 输出: true
 * 
 */
public class Solution {
    public bool IsValid(string s) {
        if (string.IsNullOrEmpty(s))
        {
            return true;
        }
        int len = 0;
        while (len != s.Length)
        {
            len = s.Length;
            if (s.IndexOf("()")!=-1)
            {
                s = s.Substring(0,s.IndexOf("()"))+s.Substring(s.IndexOf("()")+2);
                if (s.Length == 0)
                {
                    return true;
                }
            }
            if (s.IndexOf("[]")!=-1)
            {
                s = s.Substring(0,s.IndexOf("[]"))+s.Substring(s.IndexOf("[]")+2);
                if (s.Length == 0)
                {
                    return true;
                }
            }
            if (s.IndexOf("{}")!=-1)
            {
                s = s.Substring(0,s.IndexOf("{}"))+s.Substring(s.IndexOf("{}")+2);
                if (s.Length == 0)
                {
                    return true;
                }
            }            
        }
        return false;
    }
}
