/*
 * @lc app=leetcode.cn id=315 lang=csharp
 *
 * [315] 计算右侧小于当前元素的个数
 */

// @lc code=start
using System;
using System.Collections.Generic;
using System.Linq;

public class TreeNode<T>
{
    public T Data;
    public TreeNode<T> Left;
    public TreeNode<T> Right;
    public TreeNode<T> Parent;

    public TreeNode(T val, TreeNode<T> pa)
    {
        Data = val;
        Parent = pa;
    }
}

public class Solution
{
    public IList<int> CountSmaller(int[] nums)
    {
        List<int> list = nums.ToList();
        TreeNode<int> root = BuildArrayTree(list);
        
    }

    public TreeNode<int> BuildArrayTree(List<int> list)
    {

    }
}
// @lc code=end

