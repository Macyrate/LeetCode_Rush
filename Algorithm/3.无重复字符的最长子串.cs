/*
 * @lc app=leetcode.cn id=3 lang=csharp
 *
 * [3] 无重复字符的最长子串
 */

// @lc code=start

using System;
using System.Collections.Generic;
using System.Linq;
public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        int longestLength = 0, start = 0, end = 0;

        Dictionary<char, int> dict = new Dictionary<char, int>();   //用字典存储当前处理区段中的字符与下标

        for (end = 0; end < s.Length; end++)
        {
            //区段末尾出现了窗口中已有的字符，冲突
            if (dict.ContainsKey(s[end]))
            {
                foreach (var n in s[start..dict[s[end]]])
                {
                    dict.Remove(n);             //删掉哈希表里没用的部分
                }
                start = dict[s[end]] + 1;       //窗口开头挪到已出现的重复字符后面
                dict[s[end]] = end;             //更新重复字符的下标
            }
            //没冲突，把新的字符加入哈希表
            else
            {
                dict.Add(s[end], end);
            }
            if (end + 1 - start > longestLength)
                longestLength = end + 1 - start;
        }
        return longestLength;
    }
}
// @lc code=end

