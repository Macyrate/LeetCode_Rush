/*
 * @lc app=leetcode.cn id=11 lang=csharp
 *
 * [11] 盛最多水的容器
 */

// @lc code=start

using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int MaxArea(int[] height)
    {
        int start = 0, end = 1, max = 0;     //表示当前处理窗口的首尾

        while (start < height.Length - end)
        {
            //计算目前窗口的容积，更新最大容积记录
            max = Math.Max(max, Math.Min(height[start], height[^end]) * (height.Length - end - start));
            //根据木桶效应，短的一边限制了容积，将它移动一下
            _ = height[start] < height[^end] ? start++ : end++;
        }
        return max;
    }
}
// @lc code=end

