/*
 * @lc app=leetcode.cn id=1 lang=csharp
 *
 * [1] 两数之和
 */
// @lc code=start
// using System.Collections.Generic;
// using System.Linq;
// using System;
public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        //用哈希表存储数组中元素的值与下标
        Dictionary<int, int> dict = new Dictionary<int, int>();

        for (int idx = 0; idx < nums.Length; idx++)
        {
            //寻找哈希表里有没有正好能加成target的
            if (dict.ContainsKey(target - nums[idx]))
            {
                return new int[] { idx, dict[target - nums[idx]] };
            }

            //没找到就在哈希表中添加新元素，TryAdd不会添加重复元素
            dict.TryAdd(nums[idx], idx);
        }

        return new int[2] { -1, -1 }; //实在没有，则返回{ -1, -1 }
    }
}

// @lc code=end
