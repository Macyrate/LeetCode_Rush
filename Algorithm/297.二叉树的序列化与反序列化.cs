/*
 * @lc app=leetcode.cn id=297 lang=csharp
 *
 * [297] 二叉树的序列化与反序列化
 */

// @lc code=start
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
using System;
using System.Collections.Generic;
using System.Linq;

public class Codec
{

    // Encodes a tree to a single string.
    public string serialize(TreeNode root)
    {
        if (root == null)
            return "[]";
        List<TreeNode> listNode = new List<TreeNode>();
        Queue<TreeNode> queueNode = new Queue<TreeNode>();
        queueNode.Enqueue(root);
        while (queueNode.Any(x => x != null))
        {
            TreeNode dealNode = queueNode.Dequeue();
            listNode.Add(dealNode);
            if (dealNode == null)
                continue;
            queueNode.Enqueue(dealNode?.left);
            queueNode.Enqueue(dealNode?.right);
        }
        string[] strs = listNode.Select(x => (x?.val.ToString()) ?? "null").ToArray();
        string ret = "[" + string.Join(",", strs) + "]";
        System.Console.WriteLine(ret);
        return ret;
    }

    // Decodes your encoded data to tree.
    public TreeNode deserialize(string data)
    {
        if (data == "[]")
            return null;
        data = data.TrimStart('[');
        data = data.TrimEnd(']');
        List<string> strs = data.Split(',').ToList();
        Queue<TreeNode> queueNode = new Queue<TreeNode>();
        TreeNode root = new TreeNode(int.Parse(strs[0]));
        queueNode.Enqueue(root);
        strs.RemoveAt(0);
        while (strs.Any() && queueNode.Any(x => x != null))
        {
            TreeNode dealNode = queueNode.Dequeue();
            if (dealNode == null)
                continue;
            dealNode.left = strs[0] == "null" ? null : new TreeNode(int.Parse(strs[0]));
            strs.RemoveAt(0);
            queueNode.Enqueue(dealNode.left);
            if (strs.Any())
            {
                dealNode.right = strs[0] == "null" ? null : new TreeNode(int.Parse(strs[0]));
                strs.RemoveAt(0);
                queueNode.Enqueue(dealNode.right);
            }

        }
        return root;
    }
}

// Your Codec object will be instantiated and called as such:
// Codec codec = new Codec();
// codec.deserialize(codec.serialize(root));
// @lc code=end

