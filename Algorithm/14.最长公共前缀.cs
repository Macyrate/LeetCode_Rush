/*
 * @lc app=leetcode.cn id=14 lang=csharp
 *
 * [14] 最长公共前缀
 */

// @lc code=start
using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {
        if (strs.Length == 0)
            return "";
        strs = strs.OrderBy(x => x.Length).ToArray();
        string prefix = strs[0];
        foreach (string str in strs)
        {
            for (int i = prefix.Length - 1; i >= 0; i--)
            {
                if (str[i] != prefix[i])
                {
                    prefix = prefix[..i];
                }
            }
        }
        return prefix;
    }
}
// @lc code=end

