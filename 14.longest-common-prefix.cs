/*
 * @lc app=leetcode.cn id=14 lang=csharp
 *
 * [14] 最长公共前缀
 *
 * https://leetcode-cn.com/problems/longest-common-prefix/description/
 *
 * algorithms
 * Easy (31.17%)
 * Total Accepted:    44.7K
 * Total Submissions: 142.9K
 * Testcase Example:  '["flower","flow","flight"]'
 *
 * 编写一个函数来查找字符串数组中的最长公共前缀。
 * 
 * 如果不存在公共前缀，返回空字符串 ""。
 * 
 * 示例 1:
 * 
 * 输入: ["flower","flow","flight"]
 * 输出: "fl"
 * 
 * 
 * 示例 2:
 * 
 * 输入: ["dog","racecar","car"]
 * 输出: ""
 * 解释: 输入不存在公共前缀。
 * 
 * 
 * 说明:
 * 
 * 所有输入只包含小写字母 a-z 。
 * 
 */
public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        if (strs.Length == 0)
        {
            return "";
        }
        int j = 0;
        string currentStr = "";
        bool iscontinue = true;
        while(true){
            if (strs[0].Length > j){
                currentStr = strs[0][j].ToString();
            }                  
            for (int i = 0; i < strs.Length; i++)
            {
                if (strs[i].Length <= j || currentStr!=strs[i][j].ToString())
                {
                    iscontinue = false;
                    break;
                }
            }
            if (!iscontinue)
            {
                break;
            }
            j++;
        }
        return strs[0].Substring(0,j);
    }
}
