/*
 * @lc app=leetcode.cn id=189 lang=csharp
 *
 * [189] 旋转数组
 */

// @lc code=start

using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public void Rotate(int[] nums, int k)
    {
        k = k % nums.Length;        //预先取余，避免索引出问题

        //整个反转，再把两个部分分别反转，Magic！
        Array.Reverse(nums);
        Array.Reverse(nums, 0, k);
        Array.Reverse(nums, k, nums.Length - k);
    }
}
// @lc code=end

