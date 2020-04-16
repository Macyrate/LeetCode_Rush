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
        Dictionary<int, int> dict = new Dictionary<int, int>();     //用哈希表存储数组中元素的值与下标
        for (int i = 0; i < nums.Length; i++)
        {
            if (dict.ContainsKey(nums[i]))                          //由于数组中元素的值可能重复以造成碰撞，需要处理
            {
                if (nums[i] * 2 == target)                          //若重复的数刚好是target的一半，则找到了答案
                    return new int[] { dict[nums[i]], i };
            }
            else
            {
                dict.Add(nums[i], i);                               //一般情况下，直接加入哈希表
                if (dict.ContainsKey(target - nums[i]) &&           //寻找哈希表里有没有正好能加成target的
                    dict[target - nums[i]] != i)                    //光有还不行，万一自己刚好是target的一半，会找到自己
                    return new int[] { dict[target - nums[i]], i };
            }
        }
        return new int[] { -1, -1 };                                //实在没有，则返回{ -1, -1 }
    }
}
// @lc code=end

