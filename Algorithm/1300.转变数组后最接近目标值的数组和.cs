/*
 * @lc app=leetcode.cn id=1300 lang=csharp
 *
 * [1300] 转变数组后最接近目标值的数组和
 */

// @lc code=start
using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int FindBestValue(int[] arr, int target)
    {
        Array.Sort(arr);
        int avr = (int)((float)target / arr.Length + 0.49f);

        for (int x = 0; x < arr.Length; x++)
        {
            if (arr[..x].Sum() + arr[x] * (arr.Length - x) >= target)
                return (int)((float)(target - arr[..x].Sum()) / (arr.Length - x) + 0.49f);
        }
        return arr[^1];
    }
}
// @lc code=end

