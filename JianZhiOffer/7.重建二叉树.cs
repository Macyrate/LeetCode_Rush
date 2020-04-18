using System;
using System.Collections.Generic;
using System.Linq;

namespace PlayGround
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] preorder = { 3, 9, 20, 15, 7 };
            int[] inorder = { 9, 3, 15, 20, 7 };
            var tree = new Program().BuildTree(preorder, inorder);

        }

        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }
        }

        public TreeNode BuildTree(int[] preorder, int[] inorder)
        {
            //两种可以快速计算的情况
            if (preorder.Length == 0) return null;
            if (preorder.Length == 1) return new TreeNode(preorder[0]);

            TreeNode node = new TreeNode(preorder[0]);

            //前序遍历序列的第一个就是根节点，找出其在中序遍历中的索引
            int rootIndexInInOrder = Array.IndexOf(inorder, preorder[0]);

            //利用根节点的索引，把中序遍历序列划分为左子树和右子树
            int[] leftInorder = rootIndexInInOrder != 0 ? inorder[..rootIndexInInOrder].ToArray() : new int[0];
            int[] rightInorder = rootIndexInInOrder != inorder.Length - 1 ? inorder[(rootIndexInInOrder + 1)..].ToArray() : new int[0];

            //按照左右子树的序列长度，把前序遍历序列划分成左子树和右子树
            int[] leftPreOrder = leftInorder.Length != 0 ? preorder[1..(leftInorder.Length + 1)].ToArray() : new int[0];
            int[] rightPreOrder = rightInorder.Length != 0 ? preorder[(leftPreOrder.Length + 1)..].ToArray() : new int[0];

            //对左右子树分别递归
            node.left = BuildTree(leftPreOrder, leftInorder);
            node.right = BuildTree(rightPreOrder, rightInorder);

            return node;

        }

    }
}