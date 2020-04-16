/*
 * @lc app=leetcode.cn id=349 lang=csharp
 *
 * [349] 两个数组的交集
 */

// @lc code=start
using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] Intersection(int[] nums1, int[] nums2) {
        return nums1.Intersect(nums2).ToArray();        //一行LINQ完事，别想算法了
    }
}
// @lc code=end

