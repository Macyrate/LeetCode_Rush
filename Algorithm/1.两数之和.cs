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
        Dictionary<int, int> dict = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (dict.ContainsKey(nums[i]))
            {
                if (nums[i] * 2 == target)
                    return new int[] { dict[nums[i]], i };
            }
            else
            {
                dict.Add(nums[i], i);
                if (dict.ContainsKey(target - nums[i]) &&
                    dict[target - nums[i]] != i)
                    return new int[] { dict[target - nums[i]], i };
            }
        }
        return new int[2];
    }
}
// @lc code=end

